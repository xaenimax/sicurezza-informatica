using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SottoCoperta
{
  class RC4
  {
    private const int keylength = 256;
    private int[] s_box;
		private byte[] key;

		//Inizializza la sbox
    public RC4(byte[] chiave)
    {
      s_box = new int[256];

      for( int i = 0 ; i < s_box.Length ; i++)
      {
        s_box[i] = 0;
      }
      key = new byte[keylength];
			inizializzaChiaveRC4(chiave);
    }

		//inizializza la sbox con la chiave inserita dall'utente
    public void inizializzaChiaveRC4(byte[] chiave)
    {
      for (int i = 0; i < key.Length; i++)
      {
        key[i] = chiave[i % chiave.Length];
      }

      for (int i = 0; i < 256; i++)
      {
        s_box[i] = i;
      }

      int j = 0;

      for (int i = 0; i < 256; i++)
      {
        j = (j + s_box[i] + (int)key[i % keylength]) % 256;
        int temp = s_box[i];
        s_box[i] = s_box[j];
        s_box[j] = temp;
      }
    }

		//Prende in ingresso un percorso di un file e effettua lo XOR con lo stream RC4
		//e risalva il file preso in ingresso con lo stesso nome.
		//ATTENZIONE: cifra & decifra! :D
    public void effettuaXORconKS(string percorso)
    {
      FileStream inputFile = new FileStream(percorso, FileMode.Open, FileAccess.Read);

			FileInfo fileOriginale = new FileInfo(percorso);
			//FileInfo fileCriptato = new FileInfo(fileOriginale.DirectoryName + "~" + fileOriginale.Name);

			//FileStream fsFileCriptato = fileCriptato.Create();
			FileInfo fileConTilde = creaFileConTilde(fileOriginale);
			FileStream fsFileConTilde = new FileStream(fileConTilde.FullName, FileMode.Open, FileAccess.Write);

      fileConTilde.Attributes |= FileAttributes.Hidden;

      int i = 0 ;
      int j = 0 ;

			//Scarto i primi 256byte dell'RC4
      for (int l = 0; l < 256; l++)
      {
        i = (i + 1) % 256 ;
        j = (j + s_box[i]) % 256;

        int temp = s_box[i];
        s_box[i] = s_box[j];
        s_box[j] = temp;
      }

			//Ora faccio lo XOR
			for (int l = 0; l < inputFile.Length; l++)
			{
				byte in_byte = (byte)inputFile.ReadByte();

				i = (i + 1) % 256;
				j = (j + s_box[i]) % 256;

				int temp = s_box[i];
				s_box[i] = s_box[j];
				s_box[j] = temp;

				byte stream_byte = (byte)s_box[(s_box[i] + s_box[j]) % 256];
				byte out_byte = (byte)(in_byte ^ stream_byte);

				fsFileConTilde.WriteByte(out_byte);

			}
      inputFile.Close();
			fileOriginale.Delete();
      fsFileConTilde.Close();
			File.Move(fileConTilde.FullName, fileOriginale.FullName);
    }

		//Crea un nuovo file aggiungengo una tilde all'inizio del nome del file.
		//Attenzione, per ripristinare il file senza la tilde il metodo non è stato creato
		//perchè bisgona eliminare prima il file originale (tramite fileOriginale.Delete(); )
		//e poi spostarlo tramite questa: File.Move(fileConTilde.FullName, fileOriginale.FullName);
		public static FileInfo creaFileConTilde(FileInfo nomeFile) {
			FileInfo nomeFileConTilde = new FileInfo(nomeFile.DirectoryName + "~" + nomeFile.Name);
			FileStream fsNomeFileConTilde = nomeFileConTilde.Create();
			fsNomeFileConTilde.Close();
			return nomeFileConTilde;
		}
  }
}



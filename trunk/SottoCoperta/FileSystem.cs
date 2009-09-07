using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SottoCoperta
{
  class FileSystem
  {

    public static void inserisciFile(string percorso , bool cancel , bool crypt)
    {

      FileInfo fileDaDividere = new FileInfo(percorso);
      string nomeFile = fileDaDividere.Name;
      FileStream fsDaDividere = fileDaDividere.Open(FileMode.Open, FileAccess.Read);
      
      //calcolo il numero di byte che ci saranno per parte
      int numeroDiBytePerFile = (int)(fileDaDividere.Length / Parametri.n_split);
      long resto = fileDaDividere.Length % Parametri.n_split;

      // creo i file splittati 
      FileStream[] fsFileSplittato = new FileStream[Parametri.n_split];
      FileInfo[] fileSplittato = new FileInfo[Parametri.n_split];

      string nuovoNomeFile = null ;
      bool b = true;

      while (b)
      {
        nuovoNomeFile = GeneratoreDiRandom.nomeFileRandom(Parametri.len_nuovoNomeFile);
        
        if (File.Exists(Parametri.cartella_filesystem + '\\' + nuovoNomeFile + "0.007"))
        {
          b = true ;
        }

        b = false;
      }

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fileSplittato[i] = new FileInfo(Parametri.cartella_filesystem + '\\' + nuovoNomeFile + i + ".007");
        fsFileSplittato[i] = fileSplittato[i].Create();
        fileSplittato[i].Attributes |= FileAttributes.Hidden;
      }

      // riempio i file splittati con il contenuto del file
      while (fsDaDividere.Position < fileDaDividere.Length)
      {
        long temp = fsDaDividere.Position % Parametri.n_split;
        byte temp_byte = (byte)fsDaDividere.ReadByte();
        BitArray temp_bit = new BitArray(temp_byte);
        permutazione1( ref temp_bit );
        temp_byte = ConvertToByte(temp_bit);
        fsFileSplittato[temp].WriteByte(temp_byte);
      }

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fsFileSplittato[i].Close();
      }

      //inserisciListaFile( nomeFile , nuovoNomeFile , crypt) ;

      MessageBox.Show("File suddiviso!" /*+ fsDaDividere.Position + " " + fsDaDividere.Length*/, "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

      fsDaDividere.Close();

      // se si è scelta l'opzione cassaforte il file viene cancellato
      if (cancel)
        File.Delete(percorso);
    }

    public static void estraiFile(String percorsoFileUnito , bool cancel)
    {

      long numByte = 0;
      string nomeFileUnito = null;
      string nomeFileDiviso = null;
      bool crypt = false ;
      

      FileInfo fileUnito = new FileInfo(percorsoFileUnito);
      FileStream fsFileUnito = fileUnito.Create();

      nomeFileUnito = fileUnito.Name;

      // nomeFileDiviso = trovaFile( nomeFileUnito , ref crypt);

      FileInfo[] fileDaRiunire = new FileInfo[Parametri.n_split];

      FileStream[] fsFileDaRiunire = new FileStream[Parametri.n_split];

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fileDaRiunire[i] = new FileInfo(Parametri.cartella_filesystem + '\\'+ nomeFileDiviso + i + ".007" );
        fsFileDaRiunire[i] = fileDaRiunire[i].Open(FileMode.Open, FileAccess.Read);
      }

      for (int i = 0; i < Parametri.n_split; i++)
      {
        numByte = numByte + fsFileDaRiunire[i].Length;
      }


      for (int i = 0; i < numByte; i++)
      {
        long temp = i % Parametri.n_split;
        byte temp_byte = (byte)fsFileDaRiunire[temp].ReadByte();
        BitArray temp_bit = new BitArray(temp_byte);        
        inv_permutazione1(ref temp_bit);
        temp_byte = ConvertToByte(temp_bit);
        fsFileUnito.WriteByte(temp_byte);
      }

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fsFileDaRiunire[i].Close();
      }

      fsFileUnito.Close();

      if (cancel)
      {
        for( int i = 0 ; i < Parametri.n_split ; i++)
        {
          File.Delete(Parametri.cartella_filesystem + '\\' + nomeFileDiviso + i + ".007");
        }
      }

      MessageBox.Show("File ricostruito!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
    }



  public static void filePermutazione1(string percorso)
  {
    FileInfo fileDaPermutare = new FileInfo(percorso);
    FileStream fsFileDaPermutare = fileDaPermutare.Open(FileMode.Open, FileAccess.Read);

    //calcolo il numero di byte che ci saranno per parte
    int numeroDiBytePerFile = (int)(fileDaPermutare.Length);
    

    // creo i file splittati 
    
    FileInfo filePermutato = creaFileConTilde(fileDaPermutare);
    FileStream fsFilePermutato = filePermutato.Create();
    filePermutato.Attributes |= FileAttributes.Hidden;

    for (int i = 0; i < numeroDiBytePerFile; i++)
    {
      byte in_byte = (byte)fsFileDaPermutare.ReadByte();
      BitArray in_bit = new BitArray(in_byte);
      permutazione1(ref in_bit);
      in_byte = ConvertToByte(in_bit);
      fsFilePermutato.WriteByte(in_byte);
    }

    fsFileDaPermutare.Close();
    fileDaPermutare.Delete();
    fsFilePermutato.Close();
    File.Move(filePermutato.FullName, fileDaPermutare.FullName);

  }



  public static void fileInvPermutazione1(string percorso)
  {
    FileInfo fileDaPermutare = new FileInfo(percorso);
    FileStream fsFileDaPermutare = fileDaPermutare.Open(FileMode.Open, FileAccess.Read);

    //calcolo il numero di byte che ci saranno per parte
    int numeroDiBytePerFile = (int)(fileDaPermutare.Length);


    // creo i file splittati 

    FileInfo filePermutato = creaFileConTilde(fileDaPermutare);
    FileStream fsFilePermutato = filePermutato.Create();
    filePermutato.Attributes |= FileAttributes.Hidden;

    for (int i = 0; i < numeroDiBytePerFile; i++)
    {
      byte in_byte = (byte)fsFileDaPermutare.ReadByte();
      BitArray in_bit = new BitArray(in_byte);
      inv_permutazione1(ref in_bit);
      in_byte = ConvertToByte(in_bit);
      fsFilePermutato.WriteByte(in_byte);
    }

    fsFileDaPermutare.Close();
    fileDaPermutare.Delete();
    fsFilePermutato.Close();
    File.Move(filePermutato.FullName, fileDaPermutare.FullName);

  }


  // permutazione 1 su un byte
  public static void permutazione1(ref BitArray bit)
  {
    BitArray newbit = new BitArray(bit.Length);

    for (int i = 0; i < Parametri.sts_1.Length; i++)
    {
      newbit[Parametri.sts_1[i]] = bit[i];
    }
    bit = newbit;
  }

  // inversa permutazione 1 su un byte
  public static void inv_permutazione1(ref BitArray bit)
  {
    BitArray newbit = new BitArray(bit.Length);

    for (int i = 0; i < Parametri.sts_1.Length; i++)
    {
      newbit[i] = bit[Parametri.sts_1[i]];
    }
    bit = newbit;
  }

  // converte i bit in byte
  public static byte ConvertToByte(BitArray bits)
  {
    if (bits.Count != 8)
    {
        throw new ArgumentException("bits");
    }
    byte[] bytes = new byte[1];
    bits.CopyTo(bytes, 0);
    return bytes[0];
  }


  //Crea un nuovo file aggiungengo una tilde all'inizio del nome del file.
  //Attenzione, per ripristinare il file senza la tilde il metodo non è stato creato
  //perchè bisgona eliminare prima il file originale (tramite fileOriginale.Delete(); )
  //e poi spostarlo tramite questa: File.Move(fileConTilde.FullName, fileOriginale.FullName);
  public static FileInfo creaFileConTilde(FileInfo nomeFile)
  {
    FileInfo nomeFileConTilde = new FileInfo(nomeFile.DirectoryName + "~" + nomeFile.Name);
    FileStream fsNomeFileConTilde = nomeFileConTilde.Create();
    fsNomeFileConTilde.Close();
    return nomeFileConTilde;
  }

  }






}

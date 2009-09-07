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

    // permette di inserire il file all'interno del file system in modalità backup o cassaforte 
    // e permette di scegliere se cryptare o lasciare solo nascosto il file
    public static void inserisciFile(string percorso, bool cancel, bool crypt)
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

      string nuovoNomeFile = null;
      bool b = true;

      // controllo genero un nuovo nome per il file e controllo se non è già usato
      while (b)
      {
        nuovoNomeFile = GeneratoreDiRandom.nomeFileRandom(Parametri.len_nuovoNomeFile);
        
        if (File.Exists(Parametri.cartella_filesystem + '\\' + nuovoNomeFile + "0.007"))
        {
          b = true;
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
        permutazione1(ref temp_bit);
        temp_byte = ConvertToByte(temp_bit);
        fsFileSplittato[temp].WriteByte(temp_byte);
      }

      //chiudo i file splittati creati
      for (int i = 0; i < Parametri.n_split; i++)
      {
        fsFileSplittato[i].Close();
      }

      fsDaDividere.Close();

      // inserisco il nuovo file nella lista di file del file system
      inserisciListaFile(nomeFile, nuovoNomeFile, crypt);

      MessageBox.Show("File suddiviso!" /*+ fsDaDividere.Position + " " + fsDaDividere.Length*/, "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

      // se si è scelto di cryptare il file
      if (crypt)
      {
        RC4 rc4 = new RC4(Parametri.Psw1);
        
        for (int i = 0; i < Parametri.n_split; i++)
        {
          rc4.inizializzaChiaveRC4(Parametri.Psw1);
          rc4.effettuaXORconKS(fileSplittato[i].FullName);
        }
      }

      // se si è scelta l'opzione cassaforte il file viene cancellato
      if (cancel)
        File.Delete(percorso);
    }

    public static void estraiFile(String percorsoFileUnito, bool cancel)
    {

      long numByte = 0;
      string nomeFileUnito = null;
      string nomeFileDiviso = null;
      bool crypt = false;


      FileInfo fileUnito = new FileInfo(percorsoFileUnito);
      FileStream fsFileUnito = fileUnito.Create();

      nomeFileUnito = fileUnito.Name;

      // nomeFileDiviso = trovaFile( nomeFileUnito , ref crypt);

      FileInfo[] fileDaRiunire = new FileInfo[Parametri.n_split];

      FileStream[] fsFileDaRiunire = new FileStream[Parametri.n_split];

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fileDaRiunire[i] = new FileInfo(Parametri.cartella_filesystem + '\\' + nomeFileDiviso + i + ".007");
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
        for (int i = 0; i < Parametri.n_split; i++)
        {
          File.Delete(Parametri.cartella_filesystem + '\\' + nomeFileDiviso + i + ".007");
        }
      }

      MessageBox.Show("File ricostruito!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
    }

    // inserisco il file nella lista del file system
    public static void inserisciListaFile(string nomeFile, string nuovoNomeFile, bool crypt)
    {
      if (crypt)
      {
        byte[] vettoreIV;
        vettoreIV = GeneratoreDiRandom.generaByteRandom(Parametri.len_IV);
        System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
        string temp_string = "" ;

        for (int j = 0; j < vettoreIV.Length; j++)
          temp_string += vettoreIV[j].ToString("x2");

        string value = "*" + nuovoNomeFile + "?" + temp_string + ":";
        Parametri.memoryHash.Add(nomeFile, value);

      }
      else
      {
        string value = "*" + nuovoNomeFile + ":";
        Parametri.memoryHash.Add(nomeFile, value);
      }
      
      RC4 rc4 = new RC4(Parametri.Psw1);
      memoryToFileHashTable(ref rc4);

    }

    // effettuo la permutazione1 sul file
    public static void filePermutazione1(string percorso)
    {
      FileInfo fileDaPermutare = new FileInfo(percorso);
      FileStream fsFileDaPermutare = fileDaPermutare.Open(FileMode.Open, FileAccess.Read);

      //calcolo il numero di byte che ci saranno per parte
      int numeroDiBytePerFile = (int)(fileDaPermutare.Length);

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


    // effettuo la permutazione1 inversa sul file
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

    //carica il contenuto del file list nella memoria hashTable
    public static void fileToMemoryHashTable(ref RC4 rc4)
    {
      byte[] memory;

      rc4.inizializzaChiaveRC4(Parametri.Psw1);
      memory = rc4.effettuaXORinMemory(Parametri.fileList);

      for (int l = 0; l < memory.Length; l++)
      {
        int index1 = l;
        while ('*' != (char)memory[l])
        {
          l++;
        }
        string chiaveHash;
        System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
        chiaveHash = enc.GetString(memory, index1, (l - index1));

        index1 = l;
        string valoreHash;
        string valore1Hash;
        string valore2Hash;

        enc = null;
        enc = new System.Text.ASCIIEncoding();
        valore1Hash = enc.GetString(memory, index1, Parametri.len_nuovoNomeFile + 1);
        l = l + Parametri.len_nuovoNomeFile + 1;
        index1 = l;

        if (':' == memory[l])
        {
          enc = null;
          enc = new System.Text.ASCIIEncoding();
          valore2Hash = enc.GetString(memory, index1, 1);
        }
        else
        {
          enc = null;
          enc = new System.Text.ASCIIEncoding();
          valore2Hash = enc.GetString(memory, index1, 2 + Parametri.len_IV);
          l = l + Parametri.len_IV + 1;
        }

        valoreHash = valore1Hash + valore2Hash;
        Parametri.memoryHash.Add(chiaveHash, valoreHash);
      }



    }

    // scrive la memoria della tabella hash nel file lista 
    public static void memoryToFileHashTable(ref RC4 rc4)
    {

      FileInfo fileOriginale = new FileInfo(Parametri.fileList);
      FileStream fsFileOriginale = fileOriginale.Open(FileMode.Open, FileAccess.Read);


      FileInfo nuovoFile = creaFileConTilde(fileOriginale);
      FileStream fsNuovoFile = nuovoFile.Create();
      nuovoFile.Attributes |= FileAttributes.Hidden;

      foreach (DictionaryEntry entry in Parametri.memoryHash)
      {
        byte[] key_byte;
        byte[] value_byte;
        ASCIIEncoding encoding = new ASCIIEncoding();

        key_byte = encoding.GetBytes( (string)entry.Key ) ;
        value_byte = encoding.GetBytes( (string) entry.Value );
        fsNuovoFile.Write(key_byte, 0, key_byte.Length);
        fsNuovoFile.Write(value_byte, 0, value_byte.Length);
      }
      rc4.inizializzaChiaveRC4(Parametri.Psw1);
      rc4.effettuaXORconKS(nuovoFile.FullName);
      fsFileOriginale.Close();
      fileOriginale.Delete();
      fsNuovoFile.Close();
      File.Move(nuovoFile.FullName, fileOriginale.FullName);
    }

    }
  }

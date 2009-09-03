using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace First_Application
{
  class FileSystem
  {

    private void dividiFile(FileInfo fileDaDividere)
    {

      FileStream fsDaDividere = fileDaDividere.Open(FileMode.Open, FileAccess.Read);
      //calcolo il numero di byte che ci saranno per parte

      int numeroDiBytePerFile = (int)(fileDaDividere.Length / Parametri.n_split);
      long resto = fileDaDividere.Length % Parametri.n_split;

      FileStream[] fsFileSplittato = new FileStream[Parametri.n_split];
      FileInfo[] fileSplittato = new FileInfo[Parametri.n_split];

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fileSplittato[i] = new FileInfo(@"My Documents\splitto" + i);
        fsFileSplittato[i] = fileSplittato[i].Create();
      }

      while (fsDaDividere.Position < fileDaDividere.Length)
      {
        long temp = fsDaDividere.Position % Parametri.n_split;
        fsFileSplittato[temp].WriteByte((byte)fsDaDividere.ReadByte());
      }

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fsFileSplittato[i].Close();
      }

      MessageBox.Show("File suddiviso!" /*+ fsDaDividere.Position + " " + fsDaDividere.Length*/, "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

      fsDaDividere.Close();
    }

    private void riunisciFile(String SuffissoFileDaRiunire, String nomeDelFileUnito)
    {

      long numByte = 0;
      FileInfo fileUnito = new FileInfo(@"My Documents\" + nomeDelFileUnito);
      FileStream fsFileUnito = fileUnito.Create();
      //int numeroDiBytePerFile = (int)(fileDaDividere.Length / numeroDiParti);

      FileInfo[] fileDaRiunire = new FileInfo[Parametri.n_split];

      FileStream[] fsFileDaRiunire = new FileStream[Parametri.n_split];

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fileDaRiunire[i] = new FileInfo(@"My Documents\splitto" + i);
        fsFileDaRiunire[i] = fileDaRiunire[i].Open(FileMode.Open, FileAccess.Read);
      }

      for (int i = 0; i < Parametri.n_split; i++)
      {
        numByte = numByte + fsFileDaRiunire[i].Length;
      }


      for (int i = 0; i < numByte; i++)
      {
        long temp = i % Parametri.n_split;
        fsFileUnito.WriteByte((byte)fsFileDaRiunire[temp].ReadByte());
      }

      for (int i = 0; i < Parametri.n_split; i++)
      {
        fsFileDaRiunire[i].Close();
      }

      fsFileUnito.Close();
      MessageBox.Show("File ricostruito!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
    }

  }


}

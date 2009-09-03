using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsMobile.Status;

namespace First_Application
{
	public partial class Form1 : Form
	{

        private string nomeFileCompletoSelezionato;
        private string estensioneFileSelezionato;

		public Form1()
		{
			InitializeComponent();
			button2.Hide();
			button3.Hide();
			//label1.Text = "" + (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
		}

		//private void label1_ParentChanged(object sender, EventArgs e)
		//{

		//}

		private void menuItem2_click(object sender, EventArgs e)
		{
			Form2 secondaSchermata = new Form2(this);
			secondaSchermata.Show();
		}
		
		private void menuItem1_click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = @"\My Documents\";
			openFileDialog1.ShowDialog();
			nomeFileCompletoSelezionato = openFileDialog1.FileName;
		}

		private void showButton2(object sender, EventArgs e)
		{
			button2.Show();
		}

		private void button2_click(object sender, EventArgs e)
		{
			FileInfo nota = new FileInfo(openFileDialog1.FileName);
			dividiFile(nota);
		}

		private void dividiFile(FileInfo fileDaDividere) {

			FileStream fsDaDividere = fileDaDividere.Open(FileMode.Open, FileAccess.Read);
			//calcolo il numero di byte che ci saranno per parte

            int numeroDiBytePerFile = (int)(fileDaDividere.Length / Parametri.n_split);
            long resto =  fileDaDividere.Length % Parametri.n_split ;            

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

			for (int i = 0; i < Parametri.n_split ; i++)
			{
                fsFileSplittato[i].Close();
			}

			MessageBox.Show("File suddiviso!" /*+ fsDaDividere.Position + " " + fsDaDividere.Length*/, "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			
			button3.Show();
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
                fileDaRiunire[i] = new FileInfo(@"My Documents\splitto" +i );
                fsFileDaRiunire[i] = fileDaRiunire[i].Open(FileMode.Open, FileAccess.Read);
            }

            for (int i = 0; i < Parametri.n_split; i++)
            {
                numByte = numByte + fsFileDaRiunire[i].Length;
            }


            for (int i = 0; i < numByte ; i++)
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

		private void button3_click(object sender, EventArgs e)
		{
			riunisciFile("splitto", "fileUnito.pwi");
		}

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

	}
}
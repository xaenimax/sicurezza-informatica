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
		public Form1()
		{
			InitializeComponent();
			button2.Hide();
			button3.Hide();
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
			openFileDialog1.InitialDirectory = @"\";
			openFileDialog1.ShowDialog();
			label2.Text = "Hai selezionato il file:\n " + openFileDialog1.FileName;
		}

		private void showButton2(object sender, EventArgs e)
		{
			button2.Show();
		}

		private void button2_click(object sender, EventArgs e)
		{
			FileInfo nota = new FileInfo(openFileDialog1.FileName);
			dividiFile(2, nota);
		}

		private void dividiFile(int numeroDiParti, FileInfo fileDaDividere) {

			FileStream fsDaDividere = fileDaDividere.Open(FileMode.Open, FileAccess.Read);
			//calcolo il numero di byte che ci saranno per parte

			int numeroDiBytePerFile = (int)(fileDaDividere.Length / numeroDiParti);

			for (int i = 1; i <= numeroDiParti; i++)
			{
				FileInfo fileSplittato = new FileInfo(@"My Documents\splitto" + i);
				FileStream fsFileSplittato = fileSplittato.Create();

				while (fsDaDividere.Position < (numeroDiBytePerFile*i))
				{
					fsFileSplittato.WriteByte((byte)fsDaDividere.ReadByte());
				}

				fsFileSplittato.Close();
			}

			MessageBox.Show("File suddiviso!" /*+ fsDaDividere.Position + " " + fsDaDividere.Length*/, "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			
			button3.Show();
			fsDaDividere.Close();
		}

		private void riunisciFile(int numeroDiParti, String SuffissoFileDaRiunire, String nomeDelFileUnito)
		{

			FileInfo fileUnito = new FileInfo(@"My Documents\" + nomeDelFileUnito);
			FileStream fsFileUnito = fileUnito.Create();
			//int numeroDiBytePerFile = (int)(fileDaDividere.Length / numeroDiParti);

			for (int i = 0; i < numeroDiParti; i++)
			{
				int lettoreDiByte = 0;
				FileInfo fileDaRiunire = new FileInfo(@"My Documents\splitto" + (i+1));

				FileStream fsFileDaRiunire = fileDaRiunire.Open(FileMode.Open, FileAccess.Read);

				while (lettoreDiByte < fsFileDaRiunire.Length)
				{
					fsFileUnito.WriteByte((byte)fsFileDaRiunire.ReadByte());
					lettoreDiByte++;
				}

				fsFileDaRiunire.Close();
			}

			fsFileUnito.Close();
			MessageBox.Show("File ricostruito!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
		}

		private void button3_click(object sender, EventArgs e)
		{
			riunisciFile(2, "splitto", "fileUnito.pwi");
		}

	}
}
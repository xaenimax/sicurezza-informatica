using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace First_Application
{
	public partial class Form2 : Form
	{
		Form form1;

		public Form2(Form form1)
		{
			this.form1 = form1;
			//this.Owner = form1;
			InitializeComponent();
			mostraFile();
		}

		public void mostraFile()
		{
			DirectoryInfo dInfo = new DirectoryInfo(@"\My Documents");
			//DirectoryInfo[] listaCartelle = dInfo.GetDirectories("*.*");
			//String nome = listaCartelle[0].Name;
			if (dInfo.Exists == true)
			{
				try
				{
					String listaFile = "";
					FileInfo[] file = dInfo.GetFiles("*.*");
					label2.Text = file.Length.ToString() + " elementi trovati\nDi seguito c'è l'elenco dei file trovati@:";
					for (int i = 0; i < file.Length; i++)
					{
						listaFile = listaFile + " - " + file[i].Name + "\n";
					}
						label1.Text = listaFile;
				}
				catch (DirectoryNotFoundException ex)
				{
					MessageBox.Show("Ops.. File non trovato!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ops.. E' successo qualcosaltro. Butta n'occhio va\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}
			}
			else
				MessageBox.Show("Ops.. La directory non esiste!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}

		private void menu1_click(object sender, EventArgs e)
        {
					form1.Show();
					Close();
        }

		private void menu2_click(object sender, EventArgs e)
		{
			form1.Close();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
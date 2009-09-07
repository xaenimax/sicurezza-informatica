using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SottoCoperta
{
	public partial class form_listaFilePresentiInArchivio : Form
	{

		private String[] stringhe = new String[3];

		public form_listaFilePresentiInArchivio()
		{
			InitializeComponent();
			stringhe[0] = "viao";
			stringhe[1] = "ciao";
			stringhe[2] = "ciaa";
			ordinaEpopolaListaFile(stringhe);
		}

		public void ordinaEpopolaListaFile(String[] listaFile) {

			Array.Sort(listaFile);

			int j = 0;

			while (j < 5)
			{
				for (int i = 0; i < listaFile.Length; i++)
				{
					listBox_listaFile.Items.Add(listaFile[i]);
				}
				j++;
			}
		}

		private void menuItemEsci_action(object sender, EventArgs e)
		{
			Program.close();
		}

		private void menuItemIndietro_action(object sender, EventArgs e)
		{
			Program.cambiaForm(this, new MenuPrincipale());
		}

		private void buttonEstraiFile_action(object sender, EventArgs e)
		{
			if(listBox_listaFile.Text != "")
				MessageBox.Show("TODO!!" + listBox_listaFile.Text);
			else
				MessageBox.Show("E' necessario selezionare un file per poterlo estrarre!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}
}
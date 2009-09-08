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

		private RC4 rc;

		public form_listaFilePresentiInArchivio()
		{
			InitializeComponent();
			rc = new RC4(Parametri.Psw1);
			FileSystem.fileToMemoryHashTable(ref rc);
			label_avviso.Hide();
			picture_exlamation.Hide();
			ordinaEpopolaListaFile();
		}

		public void ordinaEpopolaListaFile()
		{
			String[] listaFile;
			listaFile = Utility.hashToString(ref Parametri.memoryHash);

			for (int i = 0; i < listaFile.Length; i++)
			{
				listBox_listaFile.Items.Add(listaFile[i]);
			}

			if (listaFile.Length == 0) {
				listBox_listaFile.Hide();
				button_estraiFile.Hide();
				label_titolo.Hide();
				label_avviso.Show();
				picture_exlamation.Show();
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
			if (listBox_listaFile.Text != "")
				MessageBox.Show("TODO!!" + listBox_listaFile.Text);
			else
				MessageBox.Show("E' necessario selezionare un file per poterlo estrarre!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}
	}
}
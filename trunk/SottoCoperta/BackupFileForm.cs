using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SottoCoperta
{
	public partial class BackupFileForm : Form
	{

		private String nomeFileBackup;

		public BackupFileForm()
		{
			InitializeComponent();
			label_fileSelezionato.Hide();
			effettua_backup_button.Hide();
			label_criptare.Hide();
			check_criptaFile.Hide();
			label_nascondi.Hide();
			check_nascondi_file.Hide();
		}

		private void button_seleziona_action(object sender, EventArgs e)
		{
			if (label_fileSelezionato.Visible == true && effettua_backup_button.Visible == true && label_criptare.Visible == true && check_criptaFile.Visible == true && label_nascondi.Visible == true && check_nascondi_file.Visible == true)
			{
				label_fileSelezionato.Hide();
				effettua_backup_button.Hide();
				label_criptare.Hide();
				check_criptaFile.Hide();
				label_nascondi.Hide();
				check_nascondi_file.Hide();
			}

			//selezionaFileDialog.ShowDialog();
			//nomeFileBackup = selezionaFileDialog.FileName;

			OpenFileDialogEx selezionaFileDialog = new OpenFileDialogEx();
			selezionaFileDialog.Filter = "*.*";
			//selezionaFileDialog.Show();

			if (selezionaFileDialog.ShowDialog() == DialogResult.OK)
				nomeFileBackup = selezionaFileDialog.FileName;
			if (selezionaFileDialog.FileName == "")
				nomeFileBackup = "";

			if (nomeFileBackup == "")
				MessageBox.Show("Attenzione, non hai selezionato nessun file!");
			else
			{
				FileInfo fileSelezionato = new FileInfo(nomeFileBackup);

				label_fileSelezionato.Text = "Hai selezionato il file\n" + fileSelezionato.Name;
				label_fileSelezionato.Show();
				effettua_backup_button.Show();
				label_criptare.Show();
				check_criptaFile.Show();
				label_nascondi.Show();
				check_nascondi_file.Show();
			}
		}

		private void menu_item_indietro_Click(object sender, EventArgs e)
		{
			Program.cambiaForm(this, new MenuPrincipale());
		}

		private void effettua_backup_button_action(object sender, EventArgs e)
		{
			MessageBox.Show("TODO!!!");
		}

		//private void menu_item_esci_action(object sender, EventArgs e)
		//{

		//}

		private void menuItem_esci_action(object sender, EventArgs e)
		{
			Program.close();
		}

		private void check_criptaFile_CheckStateChanged(object sender, EventArgs e)
		{
			if (check_criptaFile.Checked == true && check_nascondi_file.Checked == false)
			{
				effettua_backup_button.Width = 161;
				effettua_backup_button.Left = 37;
				effettua_backup_button.Text = "Effettua backup e cripta";
			}
			if (check_criptaFile.Checked == false && check_nascondi_file.Checked == false)
			{
				effettua_backup_button.Width = 113;
				effettua_backup_button.Left = 60;
				effettua_backup_button.Text = "Effettua backup";
			}
			if (check_criptaFile.Checked == false && check_nascondi_file.Checked == true)
			{
				effettua_backup_button.Width = 180;
				effettua_backup_button.Left = 32;
				effettua_backup_button.Text = "Effettua backup e nascondi";
			}
			if (check_criptaFile.Checked == true && check_nascondi_file.Checked == true)
			{
				effettua_backup_button.Width = 217;
				effettua_backup_button.Left = 12;
				effettua_backup_button.Text = "Effettua backup, cripta e nascondi";
			}
		}

		//private void check_nascondi_action(object sender, EventArgs e)
		//{

		//}

		private void check_nascondi_checkStateChanged(object sender, EventArgs e)
		{
			if (check_criptaFile.Checked == true && check_nascondi_file.Checked == false)
			{
				effettua_backup_button.Width = 161;
				effettua_backup_button.Left = 37;
				effettua_backup_button.Text = "Effettua backup e cripta";
			}
			if (check_criptaFile.Checked == false && check_nascondi_file.Checked == false)
			{
				effettua_backup_button.Width = 113;
				effettua_backup_button.Left = 60;
				effettua_backup_button.Text = "Effettua backup";
			}
			if (check_criptaFile.Checked == false && check_nascondi_file.Checked == true)
			{
				effettua_backup_button.Width = 180;
				effettua_backup_button.Left = 32;
				effettua_backup_button.Text = "Effettua backup e nascondi";
			}
			if (check_criptaFile.Checked == true && check_nascondi_file.Checked == true)
			{
				effettua_backup_button.Width = 217;
				effettua_backup_button.Left = 12;
				effettua_backup_button.Text = "Effettua backup, cripta e nascondi";
			}
		}



	}
}
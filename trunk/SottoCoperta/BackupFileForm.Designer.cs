namespace SottoCoperta
{
	partial class BackupFileForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MainMenu mainMenu1;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menu_item_indietro = new System.Windows.Forms.MenuItem();
			this.menu_item_esci = new System.Windows.Forms.MenuItem();
			this.label_seleziona = new System.Windows.Forms.Label();
			this.label_titoloFormBackup = new System.Windows.Forms.Label();
			this.button_selezionaFile = new System.Windows.Forms.Button();
			this.selezionaFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.label_fileSelezionato = new System.Windows.Forms.Label();
			this.effettua_backup_button = new System.Windows.Forms.Button();
			this.check_criptaFile = new System.Windows.Forms.CheckBox();
			this.label_criptare = new System.Windows.Forms.Label();
			this.label_nascondi = new System.Windows.Forms.Label();
			this.check_nascondi_file = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menu_item_indietro);
			this.mainMenu1.MenuItems.Add(this.menu_item_esci);
			// 
			// menu_item_indietro
			// 
			this.menu_item_indietro.Text = "Indietro";
			this.menu_item_indietro.Click += new System.EventHandler(this.menu_item_indietro_Click);
			// 
			// menu_item_esci
			// 
			this.menu_item_esci.Text = "Esci";
			this.menu_item_esci.Click += new System.EventHandler(this.menuItem_esci_action);
			// 
			// label_seleziona
			// 
			this.label_seleziona.Location = new System.Drawing.Point(23, 47);
			this.label_seleziona.Name = "label_seleziona";
			this.label_seleziona.Size = new System.Drawing.Size(187, 31);
			this.label_seleziona.Text = "Selezionare il file che si intende archiviare";
			this.label_seleziona.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_titoloFormBackup
			// 
			this.label_titoloFormBackup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label_titoloFormBackup.Location = new System.Drawing.Point(43, 14);
			this.label_titoloFormBackup.Name = "label_titoloFormBackup";
			this.label_titoloFormBackup.Size = new System.Drawing.Size(157, 20);
			this.label_titoloFormBackup.Text = "Archivia di un file";
			// 
			// button_selezionaFile
			// 
			this.button_selezionaFile.Location = new System.Drawing.Point(63, 92);
			this.button_selezionaFile.Name = "button_selezionaFile";
			this.button_selezionaFile.Size = new System.Drawing.Size(111, 20);
			this.button_selezionaFile.TabIndex = 2;
			this.button_selezionaFile.Text = "Seleziona file";
			this.button_selezionaFile.Click += new System.EventHandler(this.button_seleziona_action);
			// 
			// selezionaFileDialog
			// 
			this.selezionaFileDialog.Filter = "All files (*.*)|*.*";
			// 
			// label_fileSelezionato
			// 
			this.label_fileSelezionato.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
			this.label_fileSelezionato.ForeColor = System.Drawing.Color.Red;
			this.label_fileSelezionato.Location = new System.Drawing.Point(23, 126);
			this.label_fileSelezionato.Name = "label_fileSelezionato";
			this.label_fileSelezionato.Size = new System.Drawing.Size(189, 40);
			// 
			// effettua_backup_button
			// 
			this.effettua_backup_button.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.effettua_backup_button.Location = new System.Drawing.Point(63, 224);
			this.effettua_backup_button.Name = "effettua_backup_button";
			this.effettua_backup_button.Size = new System.Drawing.Size(111, 25);
			this.effettua_backup_button.TabIndex = 6;
			this.effettua_backup_button.Text = "Effettua backup";
			this.effettua_backup_button.Click += new System.EventHandler(this.effettua_backup_button_action);
			// 
			// check_criptaFile
			// 
			this.check_criptaFile.Location = new System.Drawing.Point(188, 178);
			this.check_criptaFile.Name = "check_criptaFile";
			this.check_criptaFile.Size = new System.Drawing.Size(24, 18);
			this.check_criptaFile.TabIndex = 11;
			this.check_criptaFile.CheckStateChanged += new System.EventHandler(this.check_criptaFile_CheckStateChanged);
			// 
			// label_criptare
			// 
			this.label_criptare.Location = new System.Drawing.Point(26, 178);
			this.label_criptare.Name = "label_criptare";
			this.label_criptare.Size = new System.Drawing.Size(147, 18);
			this.label_criptare.Text = "Si desidera criptare il file?";
			// 
			// label_nascondi
			// 
			this.label_nascondi.Location = new System.Drawing.Point(12, 202);
			this.label_nascondi.Name = "label_nascondi";
			this.label_nascondi.Size = new System.Drawing.Size(171, 19);
			this.label_nascondi.Text = "Si desidera nascondere il file?";
			// 
			// check_nascondi_file
			// 
			this.check_nascondi_file.Location = new System.Drawing.Point(188, 202);
			this.check_nascondi_file.Name = "check_nascondi_file";
			this.check_nascondi_file.Size = new System.Drawing.Size(22, 19);
			this.check_nascondi_file.TabIndex = 14;
			this.check_nascondi_file.CheckStateChanged += new System.EventHandler(this.check_nascondi_checkStateChanged);
			// 
			// BackupFileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.check_nascondi_file);
			this.Controls.Add(this.label_nascondi);
			this.Controls.Add(this.label_criptare);
			this.Controls.Add(this.check_criptaFile);
			this.Controls.Add(this.effettua_backup_button);
			this.Controls.Add(this.label_fileSelezionato);
			this.Controls.Add(this.button_selezionaFile);
			this.Controls.Add(this.label_titoloFormBackup);
			this.Controls.Add(this.label_seleziona);
			this.Menu = this.mainMenu1;
			this.Name = "BackupFileForm";
			this.Text = "SottoCoperta";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_seleziona;
		private System.Windows.Forms.Label label_titoloFormBackup;
		private System.Windows.Forms.Button button_selezionaFile;
		private System.Windows.Forms.OpenFileDialog selezionaFileDialog;
		private System.Windows.Forms.Label label_fileSelezionato;
		private System.Windows.Forms.MenuItem menu_item_indietro;
		private System.Windows.Forms.MenuItem menu_item_esci;
		private System.Windows.Forms.Button effettua_backup_button;
		private System.Windows.Forms.CheckBox check_criptaFile;
		private System.Windows.Forms.Label label_criptare;
		private System.Windows.Forms.Label label_nascondi;
		private System.Windows.Forms.CheckBox check_nascondi_file;
	}
}
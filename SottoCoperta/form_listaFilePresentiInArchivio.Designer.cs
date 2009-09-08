namespace SottoCoperta
{
	partial class form_listaFilePresentiInArchivio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_listaFilePresentiInArchivio));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem_indietro = new System.Windows.Forms.MenuItem();
			this.menuItem_esci = new System.Windows.Forms.MenuItem();
			this.label_titolo = new System.Windows.Forms.Label();
			this.listBox_listaFile = new System.Windows.Forms.ListBox();
			this.button_estraiFile = new System.Windows.Forms.Button();
			this.label_avviso = new System.Windows.Forms.Label();
			this.picture_exlamation = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem_indietro);
			this.mainMenu1.MenuItems.Add(this.menuItem_esci);
			// 
			// menuItem_indietro
			// 
			this.menuItem_indietro.Text = "Indietro";
			this.menuItem_indietro.Click += new System.EventHandler(this.menuItemIndietro_action);
			// 
			// menuItem_esci
			// 
			this.menuItem_esci.Text = "Esci";
			this.menuItem_esci.Click += new System.EventHandler(this.menuItemEsci_action);
			// 
			// label_titolo
			// 
			this.label_titolo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
			this.label_titolo.Location = new System.Drawing.Point(28, 13);
			this.label_titolo.Name = "label_titolo";
			this.label_titolo.Size = new System.Drawing.Size(184, 23);
			this.label_titolo.Text = "File presenti in archivio";
			// 
			// listBox_listaFile
			// 
			this.listBox_listaFile.Location = new System.Drawing.Point(20, 13);
			this.listBox_listaFile.Name = "listBox_listaFile";
			this.listBox_listaFile.Size = new System.Drawing.Size(206, 170);
			this.listBox_listaFile.TabIndex = 1;
			// 
			// button_estraiFile
			// 
			this.button_estraiFile.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button_estraiFile.Location = new System.Drawing.Point(61, 212);
			this.button_estraiFile.Name = "button_estraiFile";
			this.button_estraiFile.Size = new System.Drawing.Size(120, 23);
			this.button_estraiFile.TabIndex = 3;
			this.button_estraiFile.Text = "Estrai file";
			this.button_estraiFile.Click += new System.EventHandler(this.buttonEstraiFile_action);
			// 
			// label_avviso
			// 
			this.label_avviso.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label_avviso.ForeColor = System.Drawing.Color.Red;
			this.label_avviso.Location = new System.Drawing.Point(19, 36);
			this.label_avviso.Name = "label_avviso";
			this.label_avviso.Size = new System.Drawing.Size(207, 147);
			this.label_avviso.Text = "ATTENZIONE!\n\n\n\n\n Non sono presenti file all\'interno dell\'archivio";
			this.label_avviso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// picture_exlamation
			// 
			this.picture_exlamation.Image = ((System.Drawing.Image)(resources.GetObject("picture_exlamation.Image")));
			this.picture_exlamation.Location = new System.Drawing.Point(90, 62);
			this.picture_exlamation.Name = "picture_exlamation";
			this.picture_exlamation.Size = new System.Drawing.Size(65, 67);
			// 
			// form_listaFilePresentiInArchivio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.picture_exlamation);
			this.Controls.Add(this.label_avviso);
			this.Controls.Add(this.button_estraiFile);
			this.Controls.Add(this.listBox_listaFile);
			this.Controls.Add(this.label_titolo);
			this.Menu = this.mainMenu1;
			this.Name = "form_listaFilePresentiInArchivio";
			this.Text = "SottoCoperta";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_titolo;
		private System.Windows.Forms.ListBox listBox_listaFile;
		private System.Windows.Forms.MenuItem menuItem_indietro;
		private System.Windows.Forms.MenuItem menuItem_esci;
		private System.Windows.Forms.Button button_estraiFile;
		private System.Windows.Forms.Label label_avviso;
		private System.Windows.Forms.PictureBox picture_exlamation;
	}
}
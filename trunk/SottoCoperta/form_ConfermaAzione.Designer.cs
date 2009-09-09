namespace SottoCoperta
{
	partial class form_ConfermaAzione
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ConfermaAzione));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem_indietro = new System.Windows.Forms.MenuItem();
			this.menuItem_Esci = new System.Windows.Forms.MenuItem();
			this.label_confermaArchiviazione = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label_confermaRecupero = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem_indietro);
			this.mainMenu1.MenuItems.Add(this.menuItem_Esci);
			// 
			// menuItem_indietro
			// 
			this.menuItem_indietro.Text = "Indietro";
			this.menuItem_indietro.Click += new System.EventHandler(this.menuItemIndietro_action);
			// 
			// menuItem_Esci
			// 
			this.menuItem_Esci.Text = "Esci";
			this.menuItem_Esci.Click += new System.EventHandler(this.menuItemEsci_action);
			// 
			// label_confermaArchiviazione
			// 
			this.label_confermaArchiviazione.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label_confermaArchiviazione.ForeColor = System.Drawing.Color.Red;
			this.label_confermaArchiviazione.Location = new System.Drawing.Point(54, 38);
			this.label_confermaArchiviazione.Name = "label_confermaArchiviazione";
			this.label_confermaArchiviazione.Size = new System.Drawing.Size(131, 45);
			this.label_confermaArchiviazione.Text = "File archiviato con successo!";
			this.label_confermaArchiviazione.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(82, 116);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 70);
			// 
			// label_confermaRecupero
			// 
			this.label_confermaRecupero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label_confermaRecupero.ForeColor = System.Drawing.Color.Red;
			this.label_confermaRecupero.Location = new System.Drawing.Point(45, 38);
			this.label_confermaRecupero.Name = "label_confermaRecupero";
			this.label_confermaRecupero.Size = new System.Drawing.Size(151, 54);
			this.label_confermaRecupero.Text = "File recuperato con successo";
			this.label_confermaRecupero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// form_ConfermaAzione
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.label_confermaRecupero);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label_confermaArchiviazione);
			this.KeyPreview = true;
			this.Menu = this.mainMenu1;
			this.Name = "form_ConfermaAzione";
			this.Text = "SottoCoperta";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuItem menuItem_indietro;
		private System.Windows.Forms.MenuItem menuItem_Esci;
		private System.Windows.Forms.Label label_confermaArchiviazione;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label_confermaRecupero;
	}
}
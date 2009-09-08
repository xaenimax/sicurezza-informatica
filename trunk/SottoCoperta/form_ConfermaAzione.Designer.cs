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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(54, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 45);
			this.label1.Text = "File archiviato con successo!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(82, 116);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 70);
			// 
			// form_ConfermaAzione
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.KeyPreview = true;
			this.Menu = this.mainMenu1;
			this.Name = "form_ConfermaAzione";
			this.Text = "SottoCoperta";
			//this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_ConfermaAzione_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuItem menuItem_indietro;
		private System.Windows.Forms.MenuItem menuItem_Esci;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
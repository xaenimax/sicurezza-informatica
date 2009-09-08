namespace SottoCoperta
{
	partial class SchermataIniziale
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchermataIniziale));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem_conferma = new System.Windows.Forms.MenuItem();
			this.menuItem_esci = new System.Windows.Forms.MenuItem();
			this.label_benvenuto = new System.Windows.Forms.Label();
			this.label_descrizione_benvenuto = new System.Windows.Forms.Label();
			this.textbox_password = new System.Windows.Forms.TextBox();
			this.label_password = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem_conferma);
			this.mainMenu1.MenuItems.Add(this.menuItem_esci);
			// 
			// menuItem_conferma
			// 
			this.menuItem_conferma.Text = "Conferma";
			this.menuItem_conferma.Click += new System.EventHandler(this.menuItem_conferma_action);
			// 
			// menuItem_esci
			// 
			this.menuItem_esci.Text = "Esci";
			this.menuItem_esci.Click += new System.EventHandler(this.menuItem_esci_action);
			// 
			// label_benvenuto
			// 
			this.label_benvenuto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label_benvenuto.Location = new System.Drawing.Point(67, 19);
			this.label_benvenuto.Name = "label_benvenuto";
			this.label_benvenuto.Size = new System.Drawing.Size(98, 20);
			this.label_benvenuto.Text = "Benvenuto";
			// 
			// label_descrizione_benvenuto
			// 
			this.label_descrizione_benvenuto.Location = new System.Drawing.Point(20, 61);
			this.label_descrizione_benvenuto.Name = "label_descrizione_benvenuto";
			this.label_descrizione_benvenuto.Size = new System.Drawing.Size(199, 33);
			this.label_descrizione_benvenuto.Text = "Per poter utilizzare il programma è necessario inserire la password:";
			// 
			// textbox_password
			// 
			this.textbox_password.Location = new System.Drawing.Point(42, 143);
			this.textbox_password.Name = "textbox_password";
			this.textbox_password.Size = new System.Drawing.Size(155, 21);
			this.textbox_password.TabIndex = 2;
			// 
			// label_password
			// 
			this.label_password.Location = new System.Drawing.Point(84, 119);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(71, 21);
			this.label_password.Text = "Password:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(77, 170);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(88, 81);
			// 
			// SchermataIniziale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.textbox_password);
			this.Controls.Add(this.label_descrizione_benvenuto);
			this.Controls.Add(this.label_benvenuto);
			this.Menu = this.mainMenu1;
			this.Name = "SchermataIniziale";
			this.Text = "SottoCoperta";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuItem menuItem_conferma;
		private System.Windows.Forms.MenuItem menuItem_esci;
		private System.Windows.Forms.Label label_benvenuto;
		private System.Windows.Forms.Label label_descrizione_benvenuto;
		private System.Windows.Forms.TextBox textbox_password;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
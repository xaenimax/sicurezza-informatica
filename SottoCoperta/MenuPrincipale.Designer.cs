namespace SottoCoperta
{
	partial class MenuPrincipale
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
      this.menuItemVuoto = new System.Windows.Forms.MenuItem();
      this.menuItem_esci = new System.Windows.Forms.MenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.button_recupera = new System.Windows.Forms.Button();
      this.button_backup = new System.Windows.Forms.Button();
      this.button_nascondi = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.Add(this.menuItemVuoto);
      this.mainMenu1.MenuItems.Add(this.menuItem_esci);
      // 
      // menuItemVuoto
      // 
      this.menuItemVuoto.Text = "";
      // 
      // menuItem_esci
      // 
      this.menuItem_esci.Text = "Esci";
      this.menuItem_esci.Click += new System.EventHandler(this.menuItem_esci_action);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(68, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 22);
      this.label1.Text = "\\";
      // 
      // button_recupera
      // 
      this.button_recupera.Location = new System.Drawing.Point(58, 83);
      this.button_recupera.Name = "button_recupera";
      this.button_recupera.Size = new System.Drawing.Size(120, 23);
      this.button_recupera.TabIndex = 1;
      this.button_recupera.Text = "Recupera un File";
      this.button_recupera.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_backup
      // 
      this.button_backup.Location = new System.Drawing.Point(58, 137);
      this.button_backup.Name = "button_backup";
      this.button_backup.Size = new System.Drawing.Size(119, 24);
      this.button_backup.TabIndex = 2;
      this.button_backup.Text = "Backup di un file";
      // 
      // button_nascondi
      // 
      this.button_nascondi.Location = new System.Drawing.Point(58, 191);
      this.button_nascondi.Name = "button_nascondi";
      this.button_nascondi.Size = new System.Drawing.Size(119, 25);
      this.button_nascondi.TabIndex = 3;
      this.button_nascondi.Text = "Nascondi un file";
      // 
      // MenuPrincipale
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(240, 268);
      this.Controls.Add(this.button_nascondi);
      this.Controls.Add(this.button_backup);
      this.Controls.Add(this.button_recupera);
      this.Controls.Add(this.label1);
      this.Menu = this.mainMenu1;
      this.Name = "MenuPrincipale";
      this.Text = "SottoCoperta";
      this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuItem menuItemVuoto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuItem menuItem_esci;
		private System.Windows.Forms.Button button_recupera;
		private System.Windows.Forms.Button button_backup;
		private System.Windows.Forms.Button button_nascondi;
	}
}
namespace SottoCoperta
{
	partial class SchermataIniziale_primoAvvio
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
			this.avanti_menuItem = new System.Windows.Forms.MenuItem();
			this.quit_menuItem = new System.Windows.Forms.MenuItem();
			this.benvenuti = new System.Windows.Forms.Label();
			this.descrizione_benvenuti = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.password_textbox = new System.Windows.Forms.TextBox();
			this.ripeti_pwd = new System.Windows.Forms.Label();
			this.ripeti_pwd_textbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.avanti_menuItem);
			this.mainMenu1.MenuItems.Add(this.quit_menuItem);
			// 
			// avanti_menuItem
			// 
			this.avanti_menuItem.Text = "Avanti";
			this.avanti_menuItem.Click += new System.EventHandler(this.avanti_menuItemAction);
			// 
			// quit_menuItem
			// 
			this.quit_menuItem.Text = "Esci";
			this.quit_menuItem.Click += new System.EventHandler(this.quit_menuItemAction);
			// 
			// benvenuti
			// 
			this.benvenuti.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.benvenuti.Location = new System.Drawing.Point(69, 6);
			this.benvenuti.Name = "benvenuti";
			this.benvenuti.Size = new System.Drawing.Size(100, 20);
			this.benvenuti.Text = "Benvenuti";
			// 
			// descrizione_benvenuti
			// 
			this.descrizione_benvenuti.Location = new System.Drawing.Point(10, 41);
			this.descrizione_benvenuti.Name = "descrizione_benvenuti";
			this.descrizione_benvenuti.Size = new System.Drawing.Size(217, 47);
			this.descrizione_benvenuti.Text = "E\' la prima volta che usi il programma. Inserisci la password che userai per acce" +
					"dere al programma:";
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(10, 101);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(73, 21);
			this.password.Text = "Password:";
			// 
			// password_textbox
			// 
			this.password_textbox.Location = new System.Drawing.Point(98, 101);
			this.password_textbox.MaxLength = 12;
			this.password_textbox.Name = "password_textbox";
			this.password_textbox.PasswordChar = '*';
			this.password_textbox.Size = new System.Drawing.Size(118, 21);
			this.password_textbox.TabIndex = 3;
			// 
			// ripeti_pwd
			// 
			this.ripeti_pwd.Location = new System.Drawing.Point(10, 130);
			this.ripeti_pwd.Name = "ripeti_pwd";
			this.ripeti_pwd.Size = new System.Drawing.Size(70, 33);
			this.ripeti_pwd.Text = "Ripeti la Password:";
			// 
			// ripeti_pwd_textbox
			// 
			this.ripeti_pwd_textbox.Location = new System.Drawing.Point(98, 142);
			this.ripeti_pwd_textbox.MaxLength = 12;
			this.ripeti_pwd_textbox.Name = "ripeti_pwd_textbox";
			this.ripeti_pwd_textbox.PasswordChar = '*';
			this.ripeti_pwd_textbox.Size = new System.Drawing.Size(118, 21);
			this.ripeti_pwd_textbox.TabIndex = 8;
			// 
			// SchermataIniziale_primoAvvio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.ripeti_pwd_textbox);
			this.Controls.Add(this.ripeti_pwd);
			this.Controls.Add(this.password_textbox);
			this.Controls.Add(this.password);
			this.Controls.Add(this.descrizione_benvenuti);
			this.Controls.Add(this.benvenuti);
			this.Menu = this.mainMenu1;
			this.Name = "SchermataIniziale_primoAvvio";
			this.Text = "SottoCoperta";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label benvenuti;
		private System.Windows.Forms.Label descrizione_benvenuti;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.TextBox password_textbox;
		private System.Windows.Forms.Label ripeti_pwd;
		private System.Windows.Forms.TextBox ripeti_pwd_textbox;
		private System.Windows.Forms.MenuItem avanti_menuItem;
		private System.Windows.Forms.MenuItem quit_menuItem;
	}
}
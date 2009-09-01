namespace First_Application
{
    partial class Form1
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
					this.menuItem1 = new System.Windows.Forms.MenuItem();
					this.menuItem2 = new System.Windows.Forms.MenuItem();
					this.label1 = new System.Windows.Forms.Label();
					this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
					this.button1 = new System.Windows.Forms.Button();
					this.label2 = new System.Windows.Forms.Label();
					this.button2 = new System.Windows.Forms.Button();
					this.button3 = new System.Windows.Forms.Button();
					this.SuspendLayout();
					// 
					// mainMenu1
					// 
					this.mainMenu1.MenuItems.Add(this.menuItem1);
					this.mainMenu1.MenuItems.Add(this.menuItem2);
					// 
					// menuItem1
					// 
					this.menuItem1.Text = "Mostra File";
					this.menuItem1.Click += new System.EventHandler(this.menuItem2_click);
					// 
					// menuItem2
					// 
					this.menuItem2.Text = "Esci";
					this.menuItem2.Click += new System.EventHandler(this.menuItem1_click);
					// 
					// label1
					// 
					this.label1.Location = new System.Drawing.Point(12, 26);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(208, 53);
					this.label1.Text = "Giochiamo con il file system del cellulare. Scegli in basso un operazione da eseg" +
							"uire";
					// 
					// openFileDialog1
					// 
					this.openFileDialog1.FileName = "openFileDialog1";
					this.openFileDialog1.Filter = "All Files (*.*) | *.*";
					this.openFileDialog1.InitialDirectory = "/";
					// 
					// button1
					// 
					this.button1.Location = new System.Drawing.Point(14, 96);
					this.button1.Name = "button1";
					this.button1.Size = new System.Drawing.Size(112, 22);
					this.button1.TabIndex = 1;
					this.button1.Text = "Seleziona un file";
					this.button1.Click += new System.EventHandler(this.button1_Click);
					// 
					// label2
					// 
					this.label2.Location = new System.Drawing.Point(14, 137);
					this.label2.Name = "label2";
					this.label2.Size = new System.Drawing.Size(206, 49);
					this.label2.TextChanged += new System.EventHandler(this.showButton2);
					// 
					// button2
					// 
					this.button2.Location = new System.Drawing.Point(12, 200);
					this.button2.Name = "button2";
					this.button2.Size = new System.Drawing.Size(148, 21);
					this.button2.TabIndex = 4;
					this.button2.Text = "Dividi il file in n parti";
					this.button2.Click += new System.EventHandler(this.button2_click);
					// 
					// button3
					// 
					this.button3.Location = new System.Drawing.Point(12, 229);
					this.button3.Name = "button3";
					this.button3.Size = new System.Drawing.Size(147, 20);
					this.button3.TabIndex = 5;
					this.button3.Text = "Ricostruisci il file";
					this.button3.Click += new System.EventHandler(this.button3_click);
					// 
					// Form1
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
					this.AutoScroll = true;
					this.ClientSize = new System.Drawing.Size(240, 268);
					this.Controls.Add(this.button3);
					this.Controls.Add(this.button2);
					this.Controls.Add(this.label2);
					this.Controls.Add(this.button1);
					this.Controls.Add(this.label1);
					this.Menu = this.mainMenu1;
					this.Name = "Form1";
					this.Text = "First Application";
					this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label1;
				private System.Windows.Forms.OpenFileDialog openFileDialog1;
				private System.Windows.Forms.Button button1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Button button2;
				private System.Windows.Forms.Button button3;
    }
}


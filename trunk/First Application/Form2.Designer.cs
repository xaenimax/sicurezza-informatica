namespace First_Application
{
    partial class Form2
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
					this.label2 = new System.Windows.Forms.Label();
					this.label1 = new System.Windows.Forms.Label();
					this.SuspendLayout();
					// 
					// mainMenu1
					// 
					this.mainMenu1.MenuItems.Add(this.menuItem1);
					this.mainMenu1.MenuItems.Add(this.menuItem2);
					// 
					// menuItem1
					// 
					this.menuItem1.Text = "Indietro";
					this.menuItem1.Click += new System.EventHandler(this.menu1_click);
					// 
					// menuItem2
					// 
					this.menuItem2.Text = "Quit";
					this.menuItem2.Click += new System.EventHandler(this.menu2_click);
					// 
					// label2
					// 
					this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
					this.label2.Location = new System.Drawing.Point(12, 15);
					this.label2.Name = "label2";
					this.label2.Size = new System.Drawing.Size(184, 31);
					this.label2.Text = "label2";
					// 
					// label1
					// 
					this.label1.Location = new System.Drawing.Point(12, 46);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(203, 188);
					this.label1.Text = "label1";
					// 
					// Form2
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
					this.AutoScroll = true;
					this.ClientSize = new System.Drawing.Size(240, 268);
					this.Controls.Add(this.label1);
					this.Controls.Add(this.label2);
					this.Menu = this.mainMenu1;
					this.Name = "Form2";
					this.Text = "Lista File";
					this.Load += new System.EventHandler(this.Form2_Load);
					this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label1;
    }
}
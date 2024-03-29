﻿//-----------------------------------------------------------------------
// 
//  Copyright (C) MOBILE PRACTICES.  All rights reserved.
//  http://www.mobilepractices.com/
//
// THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//-----------------------------------------------------------------------

namespace SottoCoperta
{
    partial class OpenFileDialogEx
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFileDialogEx));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.fileListView = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.PathSelectorComboBox = new System.Windows.Forms.ComboBox();
			this.FileSystemIcons = new System.Windows.Forms.ImageList();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			this.mainMenu1.MenuItems.Add(this.menuItem2);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Location = new System.Drawing.Point(0, 247);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(240, 21);
			this.textBox1.TabIndex = 3;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// fileListView
			// 
			this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileListView.Location = new System.Drawing.Point(0, 22);
			this.fileListView.Name = "fileListView";
			this.fileListView.Size = new System.Drawing.Size(240, 210);
			this.fileListView.SmallImageList = this.FileSystemIcons;
			this.fileListView.TabIndex = 4;
			this.fileListView.View = System.Windows.Forms.View.SmallIcon;
			this.fileListView.ItemActivate += new System.EventHandler(this.fileListView_ItemActivate);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(0, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 15);
			this.label1.Text = "File name:";
			// 
			// PathSelectorComboBox
			// 
			this.PathSelectorComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.PathSelectorComboBox.Location = new System.Drawing.Point(0, 0);
			this.PathSelectorComboBox.Name = "PathSelectorComboBox";
			this.PathSelectorComboBox.Size = new System.Drawing.Size(240, 22);
			this.PathSelectorComboBox.TabIndex = 6;
			this.PathSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.PathSelectorComboBox_SelectedIndexChanged);
			this.FileSystemIcons.Images.Clear();
			this.FileSystemIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
			this.FileSystemIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
			this.FileSystemIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
			this.FileSystemIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
			// 
			// menuItem1
			// 
			this.menuItem1.Text = "Up";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Text = "Cancel";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// OpenFileDialogEx
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.ControlBox = false;
			this.Controls.Add(this.fileListView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.PathSelectorComboBox);
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "OpenFileDialogEx";
			this.Text = "OpenFileDialogEx";
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListView fileListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox PathSelectorComboBox;
		private System.Windows.Forms.ImageList FileSystemIcons;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
    }
}
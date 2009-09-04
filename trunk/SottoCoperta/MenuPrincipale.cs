using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SottoCoperta
{
	public partial class MenuPrincipale : Form
	{
		public MenuPrincipale()
		{
			InitializeComponent();
		}

		private void menuItem1_Click(object sender, EventArgs e)
		{

		}

		private void menuItem_esci_action(object sender, EventArgs e)
		{
			Program.close();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button_backup_action(object sender, EventArgs e)
		{
			Program.cambiaForm(this, new BackupFileForm());
		}
	}
}
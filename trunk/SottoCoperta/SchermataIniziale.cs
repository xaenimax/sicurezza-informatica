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
	public partial class SchermataIniziale : Form
	{
		public SchermataIniziale()
		{
			InitializeComponent();
			textbox_password.PasswordChar = '*';
			textbox_password.MaxLength = 12;
		}

		private void menuItem_esci_action(object sender, EventArgs e)
		{
			Close(); //non passo dalla classe Program in quanto essendo il primo form chiudo direttamente questo
		}

		private void menuItem_conferma_action(object sender, EventArgs e)
		{
			Program.cambiaFormDalPrimo(this, new MenuPrincipale());
		}
	}
}
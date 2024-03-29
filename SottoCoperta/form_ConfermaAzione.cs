﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SottoCoperta
{
	public partial class form_ConfermaAzione : Form
	{
		public form_ConfermaAzione(String tipoDiConferma)
		{
			InitializeComponent();
			label_confermaArchiviazione.Hide();
			label_confermaRecupero.Hide();
			visualizzaLabel(tipoDiConferma);
		}

		private void menuItemIndietro_action(object sender, EventArgs e)
		{
			Program.cambiaForm(this, new MenuPrincipale());
		}

		private void menuItemEsci_action(object sender, EventArgs e)
		{
			Program.close();
		}

		private void visualizzaLabel(String tipoDiConferma) {
			if (tipoDiConferma == "backup")
			{
				label_confermaArchiviazione.Show();
			}
			else
				label_confermaRecupero.Show();
		
		
		}

		//private void form_ConfermaAzione_KeyDown(object sender, KeyEventArgs e)
		//{
		//  if ((e.KeyCode == System.Windows.Forms.Keys.Up))
		//  {
		//    // Up
		//  }
		//  if ((e.KeyCode == System.Windows.Forms.Keys.Down))
		//  {
		//    // Down
		//  }
		//  if ((e.KeyCode == System.Windows.Forms.Keys.Left))
		//  {
		//    // Left
		//  }
		//  if ((e.KeyCode == System.Windows.Forms.Keys.Right))
		//  {
		//    // Right
		//  }
		//  if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
		//  {
		//    // Enter
		//  }

		//}
	}
}
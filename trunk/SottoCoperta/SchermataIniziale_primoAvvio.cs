using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace SottoCoperta
{
	public partial class SchermataIniziale_primoAvvio : Form
	{

    private string passwordUtente;

		public SchermataIniziale_primoAvvio()
		{
			InitializeComponent();
		}



		private void quit_menuItemAction(object sender, EventArgs e)
		{
			Close(); //non passo dalla classe Program in quanto essendo il primo form chiudo direttamente questo
		}

		private void avanti_menuItemAction(object sender, EventArgs e)
		{
      if (controllaPassword())
      {
        
        passwordUtente = password_textbox.Text;

        Parametri.Psw1 = passwordUtente;

        FileStream fs = new FileStream(Parametri.fileconf, FileMode.Open);
        BinaryWriter bw = new BinaryWriter(fs);

        GeneratoreDiRandom.creaArrayRandom(ref Parametri.sts_11);
        GeneratoreDiRandom.creaArrayRandom(ref Parametri.sts_12);

        for (int i = 0; i < Parametri.sts_11.Length; i++)
        {
          bw.Write(Parametri.sts_11[i]);
        }

        for (int i = 0; i < Parametri.sts_12.Length; i++)
        {
          bw.Write(Parametri.sts_12[i]);
        }

        byte[] frase = new byte[16];
        byte[] md5_frase = new byte[16];


        fs.Close();

        FileSystem filesystem = new FileSystem();


      }
			else
			{
				MessageBox.Show("Attenzione, le password inserite non corrispondono");
				password_textbox.Text = "";
				ripeti_pwd_textbox.Text = "";
				password_textbox.Focus();
			}
		}

		private bool controllaPassword() {
			if (password_textbox.Text != ripeti_pwd_textbox.Text)
			{
				return false;
			}
			else
				return true;
		}

		
	}
}
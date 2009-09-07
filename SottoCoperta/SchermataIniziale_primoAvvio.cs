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

        FileStream fsConf = new FileStream(Parametri.fileconf, FileMode.Open);
        BinaryWriter bw = new BinaryWriter(fsConf);

        // genera le stringhe casuali sts_1 e sts_2
        GeneratoreDiRandom.creaArrayRandom(ref Parametri.sts_1);
        Parametri.sts_2 = GeneratoreDiRandom.generaByteRandom(Parametri.sts_2.Length);

        // scrive sts_1 nel file .conf
        for (int i = 0; i < Parametri.sts_1.Length; i++)
        {
          bw.Write(Parametri.sts_1[i]);
        }

        // scrive sts_2 nel file .conf
        for (int i = 0; i < Parametri.sts_2.Length; i++)
        {
          bw.Write(Parametri.sts_2[i]);
        }

        byte[] frase = new byte[16];
        frase = GeneratoreDiRandom.generaByteRandom(frase.Length);

        byte[] md5_frase = new byte[16];
        md5_frase = GeneratoreDiRandom.calcolaMd5(frase);

        // scrive la una frase random e la sua impronta nel file .conf
        for (int i = 0; i < frase.Length ; i++)
        {
          bw.Write(frase[i]);
        }

        for (int i = 0; i < md5_frase.Length; i++)
        {
          bw.Write(md5_frase[i]);
        }

        fsConf.Close();

        // crittografia dei file di configurazione
        passwordUtente = GeneratoreDiRandom.calcolaMd5(passwordUtente);
        Parametri.Psw1 = passwordUtente;

        RC4 rc4 = new RC4(Parametri.Psw1);
        rc4.effettuaXORconKS(Parametri.fileconf);

        rc4.inizializzaChiaveRC4(Parametri.Psw1);
        rc4.effettuaXORconKS(Parametri.fileList);

        Program.cambiaFormDalPrimo(this, new MenuPrincipale());
      }
      else
      { // 
        if (password_textbox.Text.Length >= 8)
          MessageBox.Show("Attenzione, le password inserite non corrispondono");
        if (password_textbox.Text.Length < 8)
          MessageBox.Show("Attenzione, la lunghezza della password deve essere compresa tra 8 e 12 caratteri");

        password_textbox.Text = "";
        ripeti_pwd_textbox.Text = "";
        password_textbox.Focus();
      }
    }

    // funzione per il controllo delle due password
    private bool controllaPassword()
    {
      if (password_textbox.Text != ripeti_pwd_textbox.Text)
      {
        return false;
      }
      if (password_textbox.Text.Length < 8)
      {
        return false;
      }
      else
        return true;
    }
  }
}

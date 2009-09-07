using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SottoCoperta
{
	public partial class SchermataIniziale : Form
	{
    private string passwordUtente;
    private int numeroTentativi;

		public SchermataIniziale()
		{
			InitializeComponent();
      numeroTentativi = 0;
			textbox_password.PasswordChar = '*';
			textbox_password.MaxLength = 12;
		}

		private void menuItem_esci_action(object sender, EventArgs e)
		{
			Close(); //non passo dalla classe Program in quanto essendo il primo form chiudo direttamente questo
		}

		private void menuItem_conferma_action(object sender, EventArgs e)
		{
      passwordUtente = textbox_password.Text;

      // calcolo del md5(password)
      passwordUtente = GeneratoreDiRandom.calcolaMd5(passwordUtente);
      Parametri.Psw1 = passwordUtente;

      // vengono caricati in memoria i dati del file conf decriptati
      byte[] memory;

      RC4 rc4 = new RC4(Parametri.Psw1);
      memory = rc4.effettuaXORinMemory(Parametri.fileconf);

      for (int i = 0; i < Parametri.sts_1.Length; i++)
      {
        int temp = BitConverter.ToInt32(memory, i * 4);
        Parametri.sts_1[i] = temp;
      }

      for (int i = 0; i < Parametri.sts_2.Length; i++)
      {
        int temp_index = (Parametri.sts_1.Length * 4) +i ;
        Parametri.sts_2[i] = memory[temp_index];
      }

      byte[] frase = new byte[16];
      byte[] md5_frase = new byte[16];

      for (int i = 0; i < frase.Length; i++)
      {
        int temp_index = (Parametri.sts_1.Length * 4) + Parametri.sts_2.Length +i;
        frase[i] = memory[temp_index];
      }

      for (int i = 0; i < md5_frase.Length; i++)
      {
        int temp_index = (Parametri.sts_1.Length * 4) + Parametri.sts_2.Length + frase.Length + i;
        md5_frase[i] = memory[temp_index];
      }

      // controllo che md5(frase) == md5_frase ossia se l'md5 calcolato su una stringa 
      //del file conf è uguale a quello calcolato al primo avvio del programma e inserito nel file conf
      byte[] temp_frase_md5 = new byte[16]; 
      temp_frase_md5 = GeneratoreDiRandom.calcolaMd5(frase);

      bool array_uguali = true;

      for (int i = 0; i < temp_frase_md5.Length && array_uguali; i++)
      {
        if (temp_frase_md5[i] == md5_frase[i])
        {}
        else
        {
          array_uguali = false;
        }
      }
      //se la password non è corretta 
      if (!array_uguali)
      {
        MessageBox.Show("La password non è corretta!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        textbox_password.Hide();
        textbox_password.Text = "";
        textbox_password.Show();
        numeroTentativi++;
      }
      else
      {
        // se l'autenticazione ha avuto successo carico in memoria la lista di file
        FileSystem.fileToMemoryHashTable(ref rc4 );
      }


        Program.cambiaFormDalPrimo(this, new MenuPrincipale());
      }
		}
	}

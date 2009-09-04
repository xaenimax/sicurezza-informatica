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
				MessageBox.Show("Le password corrispondono!"); //TODO controllare anche la creazione del file conf
                passwordUtente = password_textbox.Text;

                Parametri.Psw1 = passwordUtente;

                FileStream fs = new FileStream(Parametri.fileconf , FileMode.Open, FileAccess.Write );
                

                FileSystem filesystem = new FileSystem();

                //TODO generazione STS random;

                //String s = Encrypt(password_textbox.Text);
                //MessageBox.Show(s);
                //s = Decrypt(s);
                //MessageBox.Show(s); 

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

		//public static string Encrypt(string originalString)
		//{
		//  if (String.IsNullOrEmpty(originalString))
		//  {
		//    throw new ArgumentNullException
		//           ("The string which needs to be encrypted can not be null.");
		//  }
		//  DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
		//  MemoryStream memoryStream = new MemoryStream();
		//  CryptoStream cryptoStream = new CryptoStream(memoryStream,
		//      cryptoProvider.CreateEncryptor(), CryptoStreamMode.Write);
		//  StreamWriter writer = new StreamWriter(cryptoStream);
		//  writer.Write(originalString);
		//  writer.Flush();
		//  cryptoStream.FlushFinalBlock();
		//  writer.Flush();
		//  return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
		//}

		//public static string Decrypt(string cryptedString)
		//{
		//  if (String.IsNullOrEmpty(cryptedString))
		//  {
		//    throw new ArgumentNullException
		//       ("The string which needs to be decrypted can not be null.");
		//  }
		//  DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
		//  MemoryStream memoryStream = new MemoryStream
		//          (Convert.FromBase64String(cryptedString));
		//  CryptoStream cryptoStream = new CryptoStream(memoryStream,
		//      cryptoProvider.CreateDecryptor(), CryptoStreamMode.Read);
		//  StreamReader reader = new StreamReader(cryptoStream);
		//  return reader.ReadToEnd();
		//}
	}
}
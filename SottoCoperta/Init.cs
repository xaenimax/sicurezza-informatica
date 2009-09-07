using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SottoCoperta
{
	class Init
	{
		public static bool ctrl_firstStart() // controlla se l'applicazione è avviata per la prima volta
		{
			if (Directory.Exists(Parametri.cartella))
			{
				return false;

			}
			return true;
		}

		public static void createConf() // crea directory e file di configurazione
		{

      FileStream fs;

			DirectoryInfo dirInfo = new DirectoryInfo(Parametri.cartella);
			dirInfo.Create();
			dirInfo.Attributes |= FileAttributes.Hidden;

      DirectoryInfo dirInfoSystem = new DirectoryInfo(Parametri.cartella_filesystem);
      dirInfo.Create();
      dirInfo.Attributes |= FileAttributes.Hidden;

			FileInfo f1 = new FileInfo(Parametri.fileconf);
			fs = f1.Create();
			f1.Attributes |= FileAttributes.Hidden;
      fs.Close();

			FileInfo f2 = new FileInfo(Parametri.fileList);
			fs = f2.Create();
			f2.Attributes |= FileAttributes.Hidden;
      fs.Close();
      
			Application.Run(new SchermataIniziale_primoAvvio());
		}


		public static void normalStart() // avvio normale dell'applicazione ( avvio diverso dal primo)
		{
			Application.Run( new SchermataIniziale());
		}

		public static void initStart() // funzione principale
		{
			if (ctrl_firstStart())
			{
				createConf();
			}
			else
			{
				normalStart();
			}

		}
	}
}

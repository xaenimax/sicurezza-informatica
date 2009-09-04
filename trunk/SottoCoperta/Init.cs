﻿using System;
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
			DirectoryInfo dirInfo = new DirectoryInfo(Parametri.cartella);
			dirInfo.Create();
			dirInfo.Attributes |= FileAttributes.Hidden;

			FileInfo f1 = new FileInfo(Parametri.fileconf);
			f1.Create();
			f1.Attributes |= FileAttributes.Hidden;

			FileInfo f2 = new FileInfo(Parametri.fileList);
			f2.Create();
			f2.Attributes |= FileAttributes.Hidden;

			FileInfo f3 = new FileInfo(Parametri.fileIV);
			f3.Create();
			f3.Attributes |= FileAttributes.Hidden;
      
			Application.Run(new SchermataIniziale_primoAvvio());
		}


		public static void normalStart() // avvio normale dell'applicazione ( avvio diverso dal primo)
		{
			//Application.Run( new SchermataIniziale());

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

				int[] array = { 0, 0, 0 };

				creaArrayRandom(ref array);
			}

		}

		public static void creaArrayRandom(ref int[] vettore)
		{
			int valoreMassimo = (vettore.Length);
			Random numeroRandom = new Random();

			for (int i = 0; i < vettore.Length; i++)
			{
				//genero un numero random
				int random = numeroRandom.Next(valoreMassimo);

				bool b = true;

				for (int j = 0; j < i; j++)
				{
					if (random == vettore[j])
					{
						b = false;
						j = i;
					}
				}

				if (b)
					vettore[i] = random;
				else
					i--;
			}
		}
	}
}
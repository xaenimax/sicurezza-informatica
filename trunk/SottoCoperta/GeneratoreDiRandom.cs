using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SottoCoperta
{

	//Questa classe contiene e conterrà tutti i metodi che verranno utilizzati per generare
	//numeri random, array random e stringhe random nonchè md5

	class GeneratoreDiRandom
	{

		//Questo metodo prende in ingresso un array di int e in base alla dimensione
		//genera n numeri random tutti diversi
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


		//Questa funziona calcola l'md5 di una stringa e ritorna una stringa con l'md5
		public static string calcolaMd5(String stringaSuCuiCalcolareMd5)
		{
			String stringaMd5 = "";
			Byte[] stringaConvertitaInByte;
			Byte[] hashInByte;

			ASCIIEncoding encoding = new ASCIIEncoding();

			stringaConvertitaInByte = encoding.GetBytes(stringaSuCuiCalcolareMd5);

			MD5 controlloreMd5 = MD5.Create();
			hashInByte = controlloreMd5.ComputeHash(stringaConvertitaInByte);

			for (int i = 0; i < hashInByte.Length; i++)
				stringaMd5 += hashInByte[i].ToString("x2");

			return stringaMd5;
		}

		//Questa funzione calcola l'md5 di un array di byte e ritorna l'md5 in byte
		public static byte[] calcolaMd5(byte[] byteSuCuiCalcolareMd5)
		{
			Byte[] hashInByte;

			MD5 controlloreMd5 = MD5.Create();
			hashInByte = controlloreMd5.ComputeHash(byteSuCuiCalcolareMd5);

			return hashInByte;
		}

		//genera una stringa random di grandezza numeroCaratteriDellaStringa
		public static string generaStringaRandom(int numeroCaratteriDellaStringa)
		{
			char[] stringaRandom = new char[numeroCaratteriDellaStringa];
			int numeroRandom;
			Random generatoreRandom = new Random();

			for (int i = 0; i < numeroCaratteriDellaStringa; i++)
			{
				numeroRandom = generatoreRandom.Next(0, 255); 
				stringaRandom[i] = Convert.ToChar(numeroRandom);
			}

			String stringa = new String(stringaRandom);

			return stringa;
		}

    public static string nomeFileRandom(int numeroCaratteriDellaStringa)
    {
      char[] stringaRandom = new char[numeroCaratteriDellaStringa];
      int numeroRandom;
      Random generatoreRandom = new Random();

      for (int i = 0; i < numeroCaratteriDellaStringa; i++)
      {
        numeroRandom = generatoreRandom.Next(97, 122);
        stringaRandom[i] = Convert.ToChar(numeroRandom);
      }

      String stringa = new String(stringaRandom);

      return stringa;
    }

		//genera un array di byte random di grandezza numeroByteRandomDaGenerare
		public static byte[] generaByteRandom(int numeroByteRandomDaGenerare) {
			byte[] byteRandom = new byte[numeroByteRandomDaGenerare];
			Random generatoreRandom = new Random();
			generatoreRandom.NextBytes(byteRandom);

			return byteRandom;
		}

	}
}

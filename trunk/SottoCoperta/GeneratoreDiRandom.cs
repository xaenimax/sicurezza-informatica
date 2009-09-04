using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SottoCoperta
{

	//Questa classe contiene e conterrà tutti i metodi che verranno utilizzati per generare
	//numeri random, array random e stringhe random nonchè md5

	class GeneratoreDiRandom
	{
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

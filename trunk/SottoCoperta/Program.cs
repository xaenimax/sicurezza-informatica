using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SottoCoperta
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		private static Form primoForm;

		[MTAThread]

		static void Main()
		{
			//Console.Write(
			Parametri param = new Parametri();
			Init.initStart();
		}

		//evita la chiusura del programma e nasconde il primo form che viene visualizzato dall'utente
		public static void cambiaFormDalPrimo(Form formUscente, Form formEntrante) {
			primoForm = formUscente;
			formEntrante.Show();
			formUscente.Visible = false;
		}

		public static void cambiaForm(Form formUscente, Form formEntrante) {
			formEntrante.Show();
			formUscente.Close();
		}


		//Chiude il programma e il primo form aperto
		public static void close() {
			primoForm.Close();		
		}

	}
}
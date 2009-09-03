using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SottoCoperta
{
    public class Parametri
    {
        public static int n_split; // numero di sottofile in cui è splittato il file
        public static int[] sts_11; // permutazione all'interno del sottofile
        public static int[] sts_12; // permutazione dei sottofile
        public static string frase; //frase per verificare l'autenticazione
        public static string cartella; // cartella con i file di setting
        public static string fileconf; // file di configurazione
        public static string fileList; // lista di file del file system nascosto
        public static string fileIV; // lista di IV per l'opzione cassaforte
        public static string Psw1; // la password di autenticazione


        public Parametri()
        {
            n_split = 7;
            frase = "dg7_kl-ò3+de_3";
            cartella = @"Windows\System\set0956213";
            fileconf = @"Windows\System\set0956213\dsf341.007";
            fileList = @"Windows\System\set0956213\frt453.007" ;
            fileIV = @"Windows\System\set0956213\wtrb.007";
            sts_11 = new int[256];
            sts_12 = new int[n_split];

            for (int i = 0; i < sts_11.Length; i++)
            {
                sts_11[i] = 0;
            }

            for (int i = 0; i < sts_12.Length; i++)
            {
                sts_12[i] = 0;
            }


        }

    }
}

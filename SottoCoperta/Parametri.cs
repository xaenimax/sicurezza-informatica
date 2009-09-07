using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace SottoCoperta
{
    public class Parametri
    {
        public static int n_split; // numero di sottofile in cui è splittato il file
        public static int[] sts_1; // permutazione all'interno di un byte
        public static byte[] sts_2; // permutazione della stringa per la crittografia
        public const int len_sts_2 = 192; // lunghezza sts_2
        public const int len_nuovoNomeFile = 12; // la grandezza del nuovo nome file
        public const int len_IV = 64; // lunghezza in byte dell'IV
        public static string cartella; // cartella con i file di setting
        public static string cartella_filesystem; // cartella con i file di setting
        public static string fileconf; // file di configurazione
        public static string fileList; // lista di file del file system nascosto
        public static string Psw1; // la password di autenticazione in md5
        public static Hashtable memoryHash; // lista dei file inseriti nell'hash


        public Parametri()
        {
            n_split = 7;
            cartella = @"Windows\System\set0956213";
            cartella_filesystem = @"Windows\System\set0956213\fs";
            fileconf = @"Windows\System\set0956213\dsf341.conf";
            fileList = @"Windows\System\set0956213\frt453.conf" ;
            sts_1 = new int[8];
            sts_2 = new byte[len_sts_2];
            memoryHash = new Hashtable();

            for (int i = 0; i < sts_1.Length; i++)
            {
                sts_1[i] = 0;
            }

            for (int i = 0; i < sts_2.Length; i++)
            {
              sts_2[i] = 0;
            }


        }

    }
}

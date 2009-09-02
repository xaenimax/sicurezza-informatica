using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace First_Application
{

    public class Parametri
    {
        public static int n_split ; // numero di sottofile in cui è splittato il file
        public static int[] sts_1 ; // permutazione all'interno del sottofile

        public Parametri()
        {
            n_split = 7;
            sts_1 = new int[256] ;

            for(int i = 0 ; i < sts_1.Length ; i++)
            {
                sts_1[i] = 0;
            }


            
        }

    }



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Parametri param = new Parametri();
            Application.Run(new Form1());
        }
    }
}
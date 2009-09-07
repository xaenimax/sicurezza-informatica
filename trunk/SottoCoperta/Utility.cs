using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace SottoCoperta
{
  class Utility
  {
    // estrae tutte le chiave dell'hashtable e le inserisce in un array di string
    public static string[] hashToString(ref Hashtable hashT)
    {
      string[] stringa = new string[hashT.Count];
      int i = 0;
      foreach (DictionaryEntry entry in hashT)
      {
        stringa[i] = (string)entry.Key;
        i++;
      }
      return stringa;
    }
  }
}

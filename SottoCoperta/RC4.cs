using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SottoCoperta
{
  class RC4
  {

    private const int keylength = 256;
    private int[] s_box;
    private int index_i;
    private int index_j;
    private byte[] key;

    RC4()
    {
      s_box = new int[256];

      for( int i = 0 ; i < s_box.Length ; i++)
      {
        s_box[i] = 0;
      }

      key = new byte[key_lengh];

      index_i = 0;
      index_j = 0;
    }

    public void init_RC4(byte[] chiave)
    {
      for (int i = 0; i < key.Length; i++)
      {
        key[i] = chiave[i % chiave.Length];
      }

      for (int i = 0; i < 256; i++)
      {
        s_box[i] = i;
      }

      int j = 0;

      for (int i = 0; i < 256; i++)
      {
        j = (j + s_box[i] + (int)key[i % keylength]);
        int temp = s_box[i];
        s_box[i] = s_box[j];
        s_box[j] = temp;
      }

    }


    public void RC4_file(string percorso)
    {
      
      FileStream fs = new FileStream(percorso, FileMode.Open, FileAccess.Read);

      FileInfo fs_crypt = new FileInfo(percorso + "c");
      fs_crypt.Create();
      fs_crypt.Attributes |= FileAttributes.Hidden;
      FileStream fc = new FileStream(percorso + "c" , FileMode.Open, FileAccess.Write);



      int i = 0 ;
      int j = 0 ;
      for (int l = 0; l < fs.Length; i++)
      {
        byte in_byte = fs.ReadByte();

        i = (i + 1) % 256 ;
        j = (j + s_box[i]) % 256;

        int temp = s_box[i];
        s_box[i] = s_box[j];
        s_box[j] = temp;

        byte stream_byte = (byte) s_box[(s_box[i] + s_box[j]) % 256];

        byte out_byte = in_byte ^ stream_byte;

        fc.WriteByte(out_byte);

      }

      fs.Close;
      fc.Close;

    }

  }
}



using System;
using System.Collections.Generic;

namespace DictionaryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Urun = new MyDictionary<int, string>();
            
            Urun.Add(2, "Silgi");
            Urun.Add(3, "Defter");
            Urun.Add(4, "Kitap");
            Urun.Add(5, "Cetvel");
            Urun.Add(19, "Zımba");

        }

    }

}

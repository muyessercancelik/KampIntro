using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem// toplama çıkarma çarpma bölme yapan bir sınıfmış gibi düşenebiliriz. Topla bir metot oluyor.
    {
        //Topla(2,3) demek aslında. 2=sayi1 3=sayi2 oluyor.
        public void Topla(int sayi1, int sayi2)//sayi1 ve sayi2 parametreler oluyor.
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + toplam);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + cikarma);
        }
    }
}

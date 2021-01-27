using System;
using System.Collections.Generic;//Buradaki sınıfları kullanacağım demek. Bunu ekledik o nedenle. List kullanabilmek için. Listteki ampüle tıklayınca geldi.

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {   //stack             //heap
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };//4 elemanlı bir dizi, 5.yi ekleyemiyoruz. Ekliyoruz ancak eskiler gidiyor. List ekliyoruz bu nedenle.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);//Bu diziye yeni bir eleman eklemek istiyorsun diyelim ki.


            //isimler = new string[5];//Bu satırı ekleyince hata gitti. //new dediğin anda yeni bir adres yeni bir yer yeni boş bir array oluşturdun. Adresi değişti isimlerin.
            //isimler[4] = "İlker";//Yeni array de ilker var onu okudu ancak yeni array de Engin yok onu okumaz.Atamadın çünkü.
            //Console.WriteLine(isimler[4]);//Çalışmadı hata verdi.
            //Console.WriteLine(isimler[0]);//Ama ben tekrar Engin yazdırmak istediğimde ekrana geldi ama boş geldi.

            //Bu sorunu gidermek için KOLEKSİYONLAR kullanılır.
            //Değerlerimizi kaybetmeyi engelleyen bir alt yapı var. Javada da bu kullanırı hep array ler yerine.

            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil" };//List aslında bir sınıf.Yeşil renkte olanlar sınıf.
            //isimler2.Add("Engin");//Böyle yapabilirsin ama yukarıdaki gibi kullanılır.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //Eğer C#ta List olmasaydı biz kendi koleksiyonumuzu nasıl yazardık? Cevabı GenericsIntro da :)
            


        }
    }
}

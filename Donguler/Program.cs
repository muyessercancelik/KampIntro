using System;

namespace Donguler         //Birbirini tekrar eden alanlar için döngüleri kullanırız.
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);   // Manuel yazdık asla böyle kullanılmaz. 


            //array - dizi kullanılır.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)  //Dizi temelli yapıları tek tek dönmeye(dolaşmaya) yarar. Dizilere uygulanır.kurs=alians - yani takma isim, istediğin adı verebilirsin.
            {
                Console.WriteLine(kurs);    //Sektörde genellikle dizi dolaşmak için foreach kullanılır. Ama for da kullanan var. Foreach kolay dolaşır.
            }

            Console.WriteLine("Footer Alanı");


                                            //i+=2 olarak da yazabilirsin aynı işlem.
           // for (int i = 1; i <= 10; i=i+2)  //Javadaki for ile aynı kod bloğu - 1den başlayacak ve i<10 şartını sağlayana kadar devam et ve 1 1 artır.
           // {
           //     Console.WriteLine(i);   //i=1 i<10 mu? evet o zaman 1 artır. 10<10 mu? hayır. o zaman döngü durur.
           // }
        }
    }
}

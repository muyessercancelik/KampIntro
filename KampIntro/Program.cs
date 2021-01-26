using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //string kategoriEtiketi = "Kategori";
            //değer tutucu, alias
            //Kodlar yukarıdan aşağıya doğru çalışır.

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000; //int tam sayıları tutmak için
            double faizOrani = 1.45;  //ondalıklı sayıları tutmak için


            bool sistemeGirisYapmisMi = true;   //Buradaki true/false gerçek hayatta bir veri kaynağından gelmektedir.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }




            if (sistemeGirisYapmisMi == true)  //Parantez içi şartım. Şartım gerçekleşiyorsa aşağıdaki süslü parantez içini çalıştır demek.
                                                // İki kere taba bas if şart bloğunu otomatik olarak ekler.
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");  //Burada iki şart var, ya if ya da else çalışır. İkisi aynı anda çalışmaz.
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);

            string state = "success";
            switch (state)
            {
                case "success":
                    Console.WriteLine("Giriş Başarılı");
                    break;
                case "error":
                    Console.WriteLine("Giriş Başarısız");
                    break;
                case "information":
                    Console.WriteLine("Giriş Bilgileri yanlış");
                    break;
                default:
                    Console.WriteLine("Hataaa");
                    break;
            }

        }
    }
}

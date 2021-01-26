using System;

namespace Metotlar
{
    class Program //Program.cs deki cs c# dan geliyor.
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya Elması"; // üçünü bir class yapmak mantıklı
                                                // class da aslında string gibi int gibi bir veri tipidir.
           
            string[] meyveler = new string[] {"Elma","Karpuz" };// burada ürün bilgilerini getirmek istesem sadece strinleri alabilirim.
                                                 // üründe double int de olabilir. Hepsi için class kullanıyoruz.

            //Class ile nasıl yapacağımıza bakalım:
            Urun urun1 = new Urun(); // Class tanımlamak için bu şekilde bir yapı kullanıyoruz.Class ın örneği denir.
                                    // Urun tipinde urun1 tanımlıyorsun aslında. class olduğu zaman new lemek gerekir.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler) //Urun yerine var desen de olur. in urunler= urunler elemanımı tek tek gez demek.
                                            // urun= urunler tek tek gezilecek, o anki elemana takma isim veriyoruz. 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");//foreach urun sayısı kadar döner.Burada 2 kere döner mesela.
            }
            //İki tür kullanım var class ta. Birisi o ürünün o müşterinin bilgilerini tutmak. Property dediğimiz proplarla yapıyoruz.
            //Diğeri ise SepetManager dır. Bunlar bir operasyon tutuyor demektir.
            Console.WriteLine("--------------Metotlar---------------------");
            //instance - örnek
            //encapsulation - kapsülleme demek. Düzensiz yapıyı düzen içine sokuyorsun, kapsüle sokuyorsun.
            //type safe-- tip güvenli. Ne ile çalışılacağını bilmek ister C#

            SepetManager sepetManager = new SepetManager(); //class lardaki gibi onun örneğini oluşturuyoruz.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2); //Burada sadece urun1 ve urun2 class ını çağırmam yeterli.
            
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);//Ama burda tek tek her ürünü yazmam gerekiyor.
                                                              //Bu nedenle Ekle metodundaki gibi yapmalısın. Ekle2 deki gibi değil.
            sepetManager.Ekle3(urun1);
            sepetManager.Ekle3(urun2);

        }
    }
}



//Dont repeat yourself - FRY - Clean Code - Best Practice
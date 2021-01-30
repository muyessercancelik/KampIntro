using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri- Tüzel Müşteri. İkisi de müşteri ama farklı türler.
            //SOLID -- Buradaki L harfi bunu söylüyor.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();//Musteri, hem gerçek hem de tüzel müşteri referans nosunu tutuyor.

            CustomerManager customManager = new CustomerManager();
            customManager.Ekle(musteri1);
            customManager.Ekle(musteri2);
            customManager.Ekle(musteri3);
            customManager.Ekle(musteri4);

        }
    }
}

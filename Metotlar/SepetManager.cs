using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager//Sepete ürün ekleme işlemi yapabiliriz. Bir class ın içinde birden fazla metot olabilir.
    {
        //naming convertion  - Metotların adları da pascal case kullanarak yazılır.
        //() parantez görürsen orada metot olduğunu anlarız.C#ta
        public void Ekle(Urun urun)// ne eklemek istediğini metoda vermen gerekiyor. Ürün ekleyeceğiz.Buna parametre denir. Urun=tipi urun=takma isim metodumuz bir parametre alıyor, parametremizin tipi Urun, urun.Adi diyip ürün adını getirmiş oluyoruz.
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urun.Adi);
            //Burada yaptığın her değişiklik Programcs sayfanda yansır.
        }
        // Ekle2 metottur.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)//stokAdedi diye bir alan ekleyin derlerse Program.cs deki tüm Ekle2 leri değiştirmen gerekiyor.
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urunAdi);
        }

        public void Ekle3(Urun urun)
        {
            Console.WriteLine("Sepete yeni ürün eklendi." + urun.Adi + " " + urun.Fiyati + "TL");
        }

        //Ekle metodundaki gibi yapmalısın. Ekle2 deki gibi değil.
    }
}

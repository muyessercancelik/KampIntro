using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) // Add yani ekleme operasyonumuz(metot) oldu. void= 
        {
            Console.WriteLine(product.ProductName + "eklendi.");
            //Biz bir ürün ekleyeceksek bu ekleme operasyonuna neyi ekleyeceğimizi söylememiz gerekir.
        }

        public void Update(Product product)// void= metot =Git ekle. Git güncelle. Git sil. Emir kipinde çağırıyoruz ve işlem yapılıyor.
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        //public int Topla(int sayi1, int sayi2)//Topla metodunu çağırırsan ben sana int tipinde bir sonuç veririm demektir.
        //{
        //    return sayi1 + sayi2;
        //}
        ////Topla2 toplama ypıyor ve ekrana yazdırıyor. 
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2); // Program.cs de Topla2'yi çağırıyorum.
        //}
        //Ekranda 9 yazacak. Topla2 metodu ikisini toplama işlemi yapıp yazdırdı.
        //Topla2 sonucunda çıkan sonucu ben başka yerlerde ya da aynı yerde kullanmak istiyorum.
        //Örneğin toplam sonucu 2 ile çarpmak istiyorum. Nasıl yapacağım?Burada mümkün değil. 
        //void emir kipidir. Git yap bitti. Ama bizim sonuca ihtiyacımız var. O nedenle int li olan kullanılır.
        //Artık toplamaSonucu ile istediğim işlemi yapabilirim. Bu nedenle return kullanılıyor.void değil.
        //Bu şekilde de yazılabilir. 


    }
}

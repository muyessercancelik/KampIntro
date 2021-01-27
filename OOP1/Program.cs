using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;    // 2 arka planda Mobilya Kategorisi olsun mesela.
            product1.ProductName = "Masa"; // Aslında bu masa, 1, 2, 500, 3 değerleri biz kullanıcıdan alıyoruz.
                                           //Şu an öğrenmek için simüle ediyoruz. Gerçek hayatta gidip buraya tek tek verileri yazmayacağız.
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //Bu şekilde oluşturabiliriz alt alta ayrı ayrı. Aşağıdaki gibi de oluşturabiliriz tek satırda.

            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35};//Bu şekilde de yazabilirsin. Genelde piyasada bu kullanılıyor. Yukarıdaki de aynı sonucu veriyor.

            //PascalCase   //camelCase  - -İsimlendirme kuralları
            ProductManager productManager = new ProductManager(); //Classlar genelde ilk kelimenin camelCase i olarak yazılır. Yani baş harfi küçük.
            //stack                         //heap
            productManager.Add(product1); 



            //productManager.Topla2(3,6);//Ekranda 9 yazacak. Topla2 metodu ikisini toplama işlemi yapıp yazdırdı.
            //                           //Topla2 sonucunda çıkan sonucu ben başka yerlerde ya da aynı yerde kullanmak istiyorum.
            //                           //Örneğin toplam sonucu 2 ile çarpmak istiyorum. Nasıl yapacağım?Burada mümkün değil. 
            //                           //void emir kipidir. Git yap bitti. Ama bizim sonuca ihtiyacımız var. O nedenle int li olan kullanılır.

            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu * 2);//Artık toplamaSonucu ile istediğim işlemi yapabilirim. Bu nedenle return kullanılıyor.void değil.
            //Console.WriteLine(productManager.Topla(3, 6) * 2); //Bu şekilde de yazılabilir. 



        }
    }
}

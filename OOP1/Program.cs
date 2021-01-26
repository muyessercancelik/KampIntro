using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35};//Bu şekilde de yazabilirsin. Genelde piyasada bu kullanılıyor. Yukarıdaki de aynı sonucu veriyor.

            //PascalCase   //camelCase  - -İsimlendirme kuralları
            ProductManager productManager = new ProductManager();
            //stack                         //heap
            productManager.Add(product1);



            productManager.Topla2(3,6);


        }
    }
}

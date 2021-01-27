using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        public int Id { get; set; }//primary key dir id.
        public int CategoryId { get; set; }//foreign key alan olduğu için bu primary keyin altında olmalıdır. Kod okunurluğu için.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }//Ürün birim fiyatı 
        public int UnitsInStock { get; set; }//Ürün stok adedi

        //CRUD operasyonları -- Yönetim panelinde Ürün ekliyoruz, güncelliyoruz, siliyoruz vs bunlara Crud operasyonları denir.
        //Creat Repeat Uptade Delete --- Bu operasyonları da ProductManager da yazıyoruz.
        //Manager  --- Bu şekilde proje içinde isimler varsa anla ki ürünle ilgili operasyonlar var onun içinde.
    }
}

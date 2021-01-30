using System;

namespace Constructors //Bir class ı new lediğimiz zaman çalışır. Bir kere çalışır bir daha çalışmaz. Yapıcı blok demektir. 
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Müyesser", LastName = "Cançelik", City = "İstanbul" };

            Customer customer2 = new Customer(2, "Mustafa", "Cançelik", "İstanbul");//Bunu ilk kez oluşturdum, çağırma işlemi yok. Ekran boş çıkar. Bunu oluşturduğunda public Customer defaultconstructor çalışıyor.
        }
    }
    class Customer
    {
        public Customer()
        {

        }

        //default Constructor 
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            //Burada senin eklediğin varsa çalışır. Yoksa arka planda default çalışacaktır.
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    //Kolay kullanım olması nedeniyle kullanılır Constructors.Normal parantez görürsen () burada bir metot mantığı var demektir.
}

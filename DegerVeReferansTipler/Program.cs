using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int sayi1 = 10;
            //int sayi2 = 30;
            //sayi1 = sayi2;
            //sayi2 = 65;
            ////sayi1??? //int, decimal,float,enum,boolean yani sayısal değerler value types = DEĞER TİPLERİ

            //int[] sayilar1 = new int[] { 10, 20, 30 };
            //int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 999;
            ////sayilar1?????
            ////array ler class lar interface ler REFERANS TİPLERİDİR = reference types sayilar1in adresi = sayilar2nin adresidir diyoruz.

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1; // Değer eşitlemesi değil, adres eşitlemesi yapıyoruz.
            person1.FirstName = "Müyesser";

            Console.WriteLine(person2.FirstName); // Müyesser yazacaktır.



            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "545455";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer; // 
            customer.FirstName = "Ahmet";


            Console.WriteLine(person3.FirstName);
            //customer = employee; // çalışmaz. customer a employee ı atayamazsın farklı türler.
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager(); 
            personManager.Add(customer);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class : Person
    class Customer: Person  // Bu class ın içinde hem Customer ın içindeki Credi kartı hem de Person class ı  var.
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee: Person  // Bu class ın içinde hem Employee ın içindeki EmployeeNumber hem de Person class ı  var.
    {
        public int EmployeeNumber { get; set; }
    }


    class PersonManager
    {
        public void Add(Person person) // aynı kodu farklı nesneler için çalıştırabilmemizi sağlıyor. Person yerine employee gönderebiliyoruz. Referans tiplerden dolayı.
        {
            Console.WriteLine(person.FirstName);
        }
    }

}

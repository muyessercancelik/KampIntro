using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList <string>isimler = new MyList<string>(); //string olarak ekledik. int de yapabilirsin.
            isimler.Add("Engin");



            Console.WriteLine("Hello World!");
        }
    }
}

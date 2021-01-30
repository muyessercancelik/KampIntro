using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();//List aslında bir class. Şimdi biz de kendi List class ımızı yapalım.
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();//Oluştu
            sehirler2.Add("iSTANBUL");//Eleman ekledi
            sehirler2.Add("iSTANBUL");
            sehirler2.Add("iSTANBUL");
            sehirler2.Add("iSTANBUL");
            sehirler2.Add("iSTANBUL");
            sehirler2.Add("iSTANBUL");
            Console.WriteLine(sehirler2.Count);//Elaman sayısını verdi
            

            //MyList2<int> plakalar = new MyList2<int>();
            //plakalar.Add2(34);
        }
    }

    class MyList<T> //Generic class
    {
        T[] _array;
        T[] tempArray;
        
        public MyList()
        {
            _array = new T[0];
            
        }

        public void Add(T item)
        {
            tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }
            _array[_array.Length - 1 ]= item;
        }

        public int Count
        {
            get { return _array.Length; }
        }


    }



    //class MyList2<T>
    //{
    //    public void Add2(T item2)
    //    {

    //    }
    //}

}

using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOrnek
{
    class MyDictionary<K, V>
    {
       
        K[] keyDizisi;
        V[] valueDizisi;
        public MyDictionary()
        {
            keyDizisi = new K[0];
            valueDizisi = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempkeyDizisi = keyDizisi;
            V[] tempvalueDizisi = valueDizisi;
            keyDizisi = new K[keyDizisi.Length + 1];
            valueDizisi = new V[valueDizisi.Length + 1];

            for (int i = 0; i < tempkeyDizisi.Length; i++)
            {
                keyDizisi[i] = tempkeyDizisi[i];
            }
            for (int i = 0; i < tempvalueDizisi.Length; i++)
            {
                valueDizisi[i] = tempvalueDizisi[i];
            }

            Console.WriteLine(key + " "+"numaralı id" +" "+ value +" "+ "olarak eklendi.");

        }
    }
}

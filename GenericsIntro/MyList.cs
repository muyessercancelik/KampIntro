using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//T yerine istediğini yazabilirsin ama bir generic varsa genelde T yazılır. Ben Mylist te T ile çalışıcm demektir.T=Type
    {
        //public void Add2(string item)//item eleman demek. String türünde bir eleman ver demek. Ama istiyorum ki programcı hangi tip derse o olsun. string yerine T yazıyoruz. //item yerine eleman desen de olur. 
        //{
        //}
        T[] items;//Add metodunun dışında yazıyorum. 
        public MyList()//constructor denir bu bloğa. Class ı new lersen MyList otomatik olarak çalışıyor.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//Geçici dizinin referansı items ın referansı artık. Geçici olarak items a verdim. Sonra yeni referans alıyorum new le.//Önceki referans adresini tutması için koruması için oluşturuyorum. Yoksa bu satır olmazsa önceki değerler uçar.
            items = new T[items.Length+1];//items.Lenght dizinin eleman sayısını verir.Dizimin elamn sayısı yukarıda 0 olduğu için 1 artırıyorum burada.
                                          //Ancak new lediğimiz için referans adresi hep değişecek. Bunun için;
            for (int i = 0; i < tempArray.Length; i++)//0dan array sayısına kadar gez items ın 0. elemanı tempArray in i ninci elemanı 
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //0dan başlıyor ya arrayler 6 eleman var 6-1 den 5 index oluyor. Aslında eklemek istediğim elemanı burada ekleyebildim.
        }
    }
}

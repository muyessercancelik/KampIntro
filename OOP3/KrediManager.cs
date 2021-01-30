using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager//Genellikle Operasyonel metotlarda kullanılır.
    {
        void Hesapla();
        void BiseyYap();//Bu iki metot tüm kredilerde olmak zorunda o nedenle interface kullandık. 
    }

    //interface leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    //Tüm kredilerde Hesapla ortaktır. Ama kodları farklıdır.

    //Logları bir dosyada bir veri tabanında ya da sms, mail olarak tutabilirsiniz. Hepsinin imzası aynı ama 
    //Dosyaya yazma kodları, Veri tabanına yazarken kodları... Hepsi farklıdır.

}

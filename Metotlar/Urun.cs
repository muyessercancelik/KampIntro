using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //İki tür kullanım var class ta. Birisi o ürünün o müşterinin bilgilerini tutmak. Property dediğimiz proplarla yapıyoruz.
        //Diğeri ise SepetManager dır. Bunlar bir operasyon tutuyor demektir.
        //Property - özellik  Benim için Ürünün ürün olabilmesi için aşağıdaki özellikleri olmalı diyorum.
        //Sepetle müşteri ile ürünle ilgili işlemlerde metotları kullanıyoruz.
        public int Id { get; set; }  //prop yazıp iki kere taba bas

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }//Yönetim sana stok adedi de olsun derse buraya gelip yeni bir özellik eklersin.
                                          //Her sayfana yansır.

    }
}

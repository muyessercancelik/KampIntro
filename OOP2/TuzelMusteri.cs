using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //miras inheritance
    class TuzelMusteri:Musteri//Tüzel müşteri bir müşteridir dedik. Müşteride olan her şey tüzelmüşteride de kabul edilir demek.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

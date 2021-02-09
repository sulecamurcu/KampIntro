using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_
{
    //Coorporate
    //Miras=Inheritance
    class TuzelMusteri:Musteri  //Bu ne demek?TüzelMusteri bir müşteridir demek.Musterinin içindeki tüm özelllikler tüzelde de var anlamına gelir.Müşteride olan her şey tüzel müşteridede var kabul edilir.
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}

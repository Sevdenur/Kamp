using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //tüzel müşteri ingilizcesi: Coorporate
    //inheritance 
    //Müşteride olan herşey tüzel müşteride de kabul edilir. Musteri sınıfı ebeveyn. 
    class TuzelMusteri : Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

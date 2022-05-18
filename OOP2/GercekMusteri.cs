using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individial
    class GercekMusteri:Musteri // Gerçek Müşteri ,müşteridir demek
    {        
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string TcNo { get; set; }
        public string Soyadi { get; set; }
        public string Adi { get; set; }
    }
}

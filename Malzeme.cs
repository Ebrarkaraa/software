using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipveHesaplama
{
    public class Malzeme
    {
        public int malzemeId { get; set; }
        public string malzemeTuru { get; set; }
        public string malzemeAdi { get; set; }
        public float en { get; set; }
        public float boy { get; set; }
        public float yukseklik { get; set; }
        public double gelisFiyati { get; set; }
        public double birimFiyati { get; set; }
        public int adet { get; set; }
        public bool plakaHesap { get; set; }
        public string kullaniciAdi { get; set; }
        public string guncellenmeTarihi { get; set; }
    }
}

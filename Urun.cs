using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipveHesaplama
{
    public class Urun
    {
        public int urunId { get; set; }
        public string urunKodu { get; set; }
        public string urunAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public int urunBasiSure { get; set; }
        public int urunAdeti { get; set; }
        public double toplamMaliyet { get; set; }
        public string guncellemeTarihi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipveHesaplama
{
    public class Siparis
    {
        public int siparisId { get; set; }
        public string siparisKodu { get; set; }
        public string siparisAdi { get; set; }
        public string kullaniciAdi { get; set; }
        public string imalatTarihi { get; set; }
        public string sevkTarihi { get; set; }
        public bool onayDurumu { get; set; }
        public string siparisBolum { get; set; }
        public string guncellemeTarihi { get; set; }
    }
}

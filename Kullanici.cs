using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipveHesaplama
{
    class Kullanici
    {
        public int kullaniciId { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSifre { get; set; }
        public bool yetki { get; set; }
        public string bolum { get; set; }
        public string guncellemeTarihi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipveHesaplama
{
    public class Parca
    {
        public int parcaId { get; set; }
        public int malzemeId { get; set; }
        public string malzemeTuru { get; set; }
        public string malzemeAdi { get; set; }
        public float en { get; set; }
        public float boy { get; set; }
        public int adet { get; set; }
        public string boya { get; set; }
        public double parcaFiyat { get; set; }
    }
}

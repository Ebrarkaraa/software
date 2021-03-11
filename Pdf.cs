using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipveHesaplama
{
    class Pdf
    {
        public int pdfId { get; set; }
        public string pdfAdi { get; set; }
        public byte[] pdfByte { get; set; }
        public string guncellemeTarihi { get; set; }
        public string KullaniciAdi { get; set; }
    }
}

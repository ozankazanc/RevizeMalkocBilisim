using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatisDetayTablo
    {
        public int DetayID { get; set; }
        public string UrunAdi { get; set; }
        public int UrunMiktari { get; set; }
        public decimal UrunBirimFiyat { get; set; }
        public decimal UrunToplamTutar { get; set; }
        public int SatisID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

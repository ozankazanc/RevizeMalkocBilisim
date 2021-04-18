using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SatisTablo
    {
        public int SatisID { get; set; }
        public string Konu { get; set; }
        public DateTime Tarih { get; set; }
        public bool SatisDurumu { get; set; }
        public int MusteriID { get; set; }
        public bool KDV { get; set; }
        public bool Sil { get; set; }
    }
}

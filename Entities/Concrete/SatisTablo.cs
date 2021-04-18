using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class SatisTablo : IEntity
    {
        [Key]
        public int SatisID { get; set; }
        public string Konu { get; set; }
        public DateTime Tarih { get; set; }
        public bool SatisDurumu { get; set; }
        public int MusteriID { get; set; }
        public bool KDV { get; set; }
        public bool Sil { get; set; }
    }
}

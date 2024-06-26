﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class OdemeTablo : IEntity
    {
        [Key]
        public int OdemeID { get; set; }
        public decimal AlinanTutar { get; set; }
        public decimal ToplamTutar { get; set; }
        public int OdemeDurumu { get; set; }
        public int KurID { get; set; }
        public int SekilID { get; set; }
        public int SatisID { get; set; }
        public int TeknikID { get; set; }
        public int MusteriID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

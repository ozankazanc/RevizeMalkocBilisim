﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class MusteriTablo : IEntity
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriIsim { get; set; }
        public string MusteriNumara { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriAdres { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        public bool Sil { get; set; } = false;
    }
}

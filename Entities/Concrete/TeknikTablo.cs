﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class TeknikTablo : IEntity
    {
        [Key]
        public int TeknikID { get; set; }
        public DateTime Tarih { get; set; }
        public string Not { get; set; }
        public int MusteriID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

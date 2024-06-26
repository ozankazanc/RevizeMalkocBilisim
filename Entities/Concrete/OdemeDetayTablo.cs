﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class OdemeDetayTablo : IEntity
    {
        [Key]
        public int OdemeDetayID { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public int OdemeID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

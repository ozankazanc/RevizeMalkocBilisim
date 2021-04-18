using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class ParcaTablo : IEntity
    {
        [Key]
        public int ParcaID { get; set; }
        public string DegisenParca { get; set; }
        public int TeknikID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

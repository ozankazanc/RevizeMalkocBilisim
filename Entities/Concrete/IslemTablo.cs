using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class IslemTablo : IEntity
    {
        [Key]
        public int IslemID { get; set; }
        public string YapilanIslem { get; set; }
        public int TeknikID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

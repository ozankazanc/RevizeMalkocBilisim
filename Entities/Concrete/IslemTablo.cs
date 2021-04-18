using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class IslemTablo : IEntity
    {
        public int IslemID { get; set; }
        public string YapilanIslem { get; set; }
        public int TeknikID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

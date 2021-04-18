using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ArizaTablo : IEntity
    {
        public int ArizaID { get; set; }
        public string ArizaBilgisi { get; set; }
        public int TeknikID { get; set; }
        public bool Sil { get; set; } = false;
    }
}

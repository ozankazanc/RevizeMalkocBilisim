using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class KurTablo : IEntity
    {
        public int KurID { get; set; }
        public string Kur { get; set; }
    }
}

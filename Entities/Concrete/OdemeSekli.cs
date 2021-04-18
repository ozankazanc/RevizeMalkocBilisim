using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OdemeSekli : IEntity
    {
        public int SekilID { get; set; }
        public string Secenek { get; set; }
    }
}

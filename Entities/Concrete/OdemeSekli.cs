using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class OdemeSekli : IEntity
    {
        [Key]
        public int SekilID { get; set; }
        public string Secenek { get; set; }
    }
}

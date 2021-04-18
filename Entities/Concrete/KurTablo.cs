using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class KurTablo : IEntity
    {
        [Key]
        public int KurID { get; set; }
        public string Kur { get; set; }
    }
}

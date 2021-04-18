using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class MKocdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=94.73.170.92;Database=MKocdb; User Id=oznkznc; Password=1234560_Ozaka.M; Trusted_Connection=True");
        }

        public DbSet<ArizaTablo> ArizaTablos { get; set; }
        public DbSet<IslemTablo> IslemTablos { get; set; }
        public DbSet<KurTablo> KurTablos { get; set; }
        public DbSet<MusteriTablo> MusteriTablos { get; set; }
        public DbSet<OdemeDetayTablo> OdemeDetayTablos { get; set; }
        public DbSet<OdemeSekli> OdemeSeklis { get; set; }
        public DbSet<OdemeTablo> OdemeTablos { get; set; }
        public DbSet<ParcaTablo> ParcaTablos { get; set; }
        public DbSet<SatisDetayTablo> SatisDetayTablos { get; set; }
        public DbSet<SatisTablo> SatisTablos { get; set; }
        public DbSet<TeknikTablo> TeknikTablos { get; set; }
    }
}

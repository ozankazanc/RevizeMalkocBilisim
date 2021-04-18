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
            optionsBuilder.UseSqlServer(@"Data Source=94.73.170.92;Initial Catalog=MKocdb; User id=oznkznc; Password=1234560_Ozaka.M;");
        }

        public DbSet<ArizaTablo> ArizaTablo { get; set; }
        public DbSet<IslemTablo> IslemTablo { get; set; }
        public DbSet<KurTablo> KurTablo { get; set; }
        public DbSet<MusteriTablo> MusteriTablo { get; set; }
        public DbSet<OdemeDetayTablo> OdemeDetayTablo { get; set; }
        public DbSet<OdemeSekli> OdemeSekli { get; set; }
        public DbSet<OdemeTablo> OdemeTablo { get; set; }
        public DbSet<ParcaTablo> ParcaTablo { get; set; }
        public DbSet<SatisDetayTablo> SatisDetayTablo { get; set; }
        public DbSet<SatisTablo> SatisTablo { get; set; }
        public DbSet<TeknikTablo> TeknikTablo { get; set; }
    }
}

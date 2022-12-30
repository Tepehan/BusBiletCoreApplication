using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-7U5PUCF6;Initial Catalog=BusTicket;" +
                "Persist Security Info=False;User ID=sa;Password=6161;" +
                "MultipleActiveResultSets=False;Encrypt=False;" +
                "TrustServerCertificate=False;Connection Timeout=30;");

                //("server=405-00 ; database=DBBusBilet ;Encrypt=False; User ID=sa;Password=1234");
        }
        
        public DbSet<Firma> firmalar { get; set; }
        public DbSet<Guzergah> guzergahlar { get; set; }
        public DbSet<Otobus> otobusler { get; set; }
        public DbSet<Kullanici> kullanicilar { get; set; }
        public DbSet<GuzergahOtobus> guzergahOtobusler { get; set; }
        public DbSet<GuzergahOtobusKullanici> guzergahOtobusKullaniciler { get; set; }

        
    }
}

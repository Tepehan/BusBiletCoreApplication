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
<<<<<<< HEAD
            optionsBuilder.UseSqlServer("Server=DESKTOP-BF2NAS2;Initial Catalog=DBBusBilet;" +
              "Persist Security Info=False;Trusted_Connection=True;" +
              "MultipleActiveResultSets=False;Encrypt=False;" +
              "TrustServerCertificate=False;Connection Timeout=30;");
=======
            optionsBuilder.UseSqlServer("server=405-03; database=DBBusBilet ;Encrypt=False; User ID=sa;Password=1234");
>>>>>>> 0bd88d9bd7735658f66fae0bb3133a1859f2df27
        }
        
        public DbSet<Firma> firmalar { get; set; }
        public DbSet<Guzergah> guzergahlar { get; set; }
        public DbSet<Otobus> otobusler { get; set; }
        public DbSet<Kullanici> kullanicilar { get; set; }
        public DbSet<GuzergahOtobus> guzergahOtobusler { get; set; }
        public DbSet<GuzergahOtobusKullanici> guzergahOtobusKullaniciler { get; set; }

        
    }
}

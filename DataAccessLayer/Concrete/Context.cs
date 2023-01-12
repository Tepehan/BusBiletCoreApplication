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
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer ("server=405-00 ; database=DBBusBilet ;Encrypt=False; User ID=sa;Password=1234");

        }       
        public DbSet<Firma> firmalar { get; set; }
        public DbSet<Guzergah> guzergahlar { get; set; }
        public DbSet<Otobus> otobusler { get; set; }
        public DbSet<Kullanici> kullanicilar { get; set; }
        public DbSet<GuzergahOtobus> seferler { get; set; }
        public DbSet<GuzergahOtobusKullanici> biletler { get; set; }
        public DbSet<Admin> adminler { get; set; }
        public DbSet<Menu> menuler { get; set; }
        public DbSet<Slider> slider { get; set; }

    }
}

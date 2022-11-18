using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Kullanici
    {
        [Key]
        public int kullaniciId { get; set; }
        [StringLength(50)]
        public string kullaniciAd { get; set; }
        [StringLength(50)]
        public string kullaniciSifre { get; set; }
        [StringLength(50)]
        public string ad { get; set; }
        [StringLength(50)]
        public string soyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        [StringLength(11)]
        public string tc { get; set; }
        [StringLength(50)]
        public string mail { get; set; }
        public bool cinsiyet { get; set; }
        [StringLength(11)]
        public string tel { get; set; }

        //guzergahOtobusKullanici ile ilişkilendirelecek.
        public ICollection<GuzergahOtobusKullanici> guzergahOtobusKullanicilar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class GuzergahOtobusKullanici
    {
        [Key]
        public int biletId { get; set; }
        [StringLength(50)]
        public string seriNo { get; set; }
        public bool odemeTipi { get; set; }
        public int koltukNo { get; set; }
        public DateTime biletKesimTarihi { get; set; }
        [StringLength(25)]
        public string yolcuAd { get; set; }
        [StringLength(25)]
        public string yolcuSoyad { get; set; }
        [StringLength(11)]
        public string yolcuTc { get; set; }
        public bool yolcuCinsiyet { get; set; }

        //guzergahOtobus ile ilişkilendirilecek.
        public int seferId { get; set; }
        public GuzergahOtobus guzergahOtobus { get; set; }
        //kullanici ile ilişkilendirilecek.
        public int kullaniciId { get; set; }
        public Kullanici kullanici { get; set; }
    }
}

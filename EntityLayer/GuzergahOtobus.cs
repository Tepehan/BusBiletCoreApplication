using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class GuzergahOtobus
    {
        [Key]
        public int seferId { get; set; }
        public int sure { get; set; }
        [StringLength(5)]
        public string kalkisSaat { get; set; }
        public DateTime tarih { get; set; }
        public double biletFiyat { get; set; }
        public bool guzergahOtobusSilindi { get; set; }

        //guzergah ile ilişkilendirilecek.
        public int guzergahId { get; set; }
        public virtual Guzergah guzergah { get; set; }
        //otobus ile ilişkilendirilecek.
        public int otobusId { get; set; }
        public virtual Otobus otobus { get; set; }
        //guzergahOtobusKullanici ile ilişkilendirilecek.
        public virtual ICollection<GuzergahOtobusKullanici> biletler { get; set; }
    }
}

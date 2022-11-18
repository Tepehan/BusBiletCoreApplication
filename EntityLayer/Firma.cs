using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Firma
    {
        [Key]
        public int firmaId { get; set; }
        [StringLength(50)]
        public string firmaAd { get; set; }
        [StringLength(300)]
        public string? iletisim { get; set; }
        [StringLength(100)]
        public string logoUrl { get; set; }
        public bool silindi { get; set; }

        //Otobus ile ilişkilendirilecek.
        public ICollection<Otobus> otobusler { get; set; }
    }
}

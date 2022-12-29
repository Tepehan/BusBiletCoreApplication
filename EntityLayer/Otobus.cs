using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Otobus
    {
        [Key]
        public int otobusId { get; set; }
        public int koltukSayisi { get; set; }
        public bool wifi { get; set; }
        public bool tv { get; set; }
        [StringLength(11)]
        public string plaka { get; set; }
        [StringLength(50)]
        public string marka { get; set; }
        [StringLength(50)]
        public string model { get; set; }

        //firma ile ilişkilendirilecek.
        public int firmaId { get; set; }
        public Firma firma { get; set; }
        //guzergahOtobus ile ilişkilendirilecek.
        public ICollection<GuzergahOtobus> guzergahOtobusler { get; set; }
    }
}

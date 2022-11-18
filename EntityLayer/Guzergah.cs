using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Guzergah
    {
        [Key]
        public int guzergahId { get; set; }
        [StringLength(20)]
        public string kalkisYeri { get; set; }
        [StringLength(20)]
        public string varisYeri { get; set; }

        //guzergahOtobus ile ilişkilendirilecek.
        public ICollection<GuzergahOtobus> guzergahOtobusler { get; set; }
    }
}

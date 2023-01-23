using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Slider
    {
        [Key]
        public int sliderId { get; set; }
        [StringLength(50)]
        public string sliderName { get; set; }
        public bool silindi { get; set; }
        [StringLength(100)]
        public string resimUrl { get; set; }
        [NotMapped]
        public  IFormFile imgFile { get; set; }

    }
}

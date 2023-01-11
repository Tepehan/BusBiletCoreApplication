using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Menu
    {
        [Key]
        public int menuId { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        [StringLength(100)]
        public string seoUrl { get; set; }
        [ForeignKey("parent")]
        public int? parentId { get; set; }
        public virtual Menu parent { get; set; }
        [InverseProperty("parent")]
        public virtual ICollection<Menu> children { get; set; }
        public bool silindi { get; set; }

    }
}

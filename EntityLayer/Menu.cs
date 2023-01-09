using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Menu
    {
        public int menuId { get; set; }
        public string name { get; set; }
        [ForeignKey("parent")]
        public int? parentId { get; set; }
        public virtual Menu parent { get; set; }
        [InverseProperty("parent")]
        public virtual ICollection<Menu> children { get; set; }
        public bool isActive { get; set; }

    }
}

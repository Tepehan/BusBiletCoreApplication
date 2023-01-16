using EntityLayer;
using System.Collections;
using System.Collections.Generic;

namespace BusBiletCoreApplication.Models
{
    public class MenuParentListModel
    {
        public Menu menuModel { get; set; }
        public IEnumerable<Menu> menuListModel { get; set; }
       
    }
}

using EntityLayer;
using System.Collections.Generic;

namespace BusBiletCoreApplication.Models
{
    public class MenuSliderModel
    {
        public IEnumerable<Slider> sliderModel { get; set; }
        public IEnumerable<Menu> menuModel { get; set; }
    }
}

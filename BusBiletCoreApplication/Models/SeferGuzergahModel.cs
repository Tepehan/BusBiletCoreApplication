using System.Collections.Generic;
using System.Threading.Tasks;
using EntityLayer;

namespace BusBiletCoreApplication.Models
{
    public class SeferGuzergahModel
    {
        public GuzergahOtobus guzergahOtobusModel { get; set; }
        public IEnumerable<Guzergah> guzergahModel { get; set; }

    }
}

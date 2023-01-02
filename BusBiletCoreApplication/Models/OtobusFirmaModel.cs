using EntityLayer;
using System.Collections.Generic;

namespace BusBiletCoreApplication.Models
{
    public class OtobusFirmaModel
    {
        public Otobus otobusModal { get; set; }
        public IEnumerable<Firma> firmaModal { get; set; }
    }
}

using EntityLayer;
using System.Collections.Generic;

namespace BusBiletCoreApplication.Models
{
    public class BiletSeferGuzergahKullaniciModel
    {
        public GuzergahOtobusKullanici biletModel { get; set; }
        public IEnumerable<GuzergahOtobus> seferModel { get; set; }
        public IEnumerable<Kullanici> kullaniciModel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace BusinessLayer
{
    public interface IGuzergahOtobusServis
    {
        public void guzergahOtobusEkle(GuzergahOtobus guzergahOtobus);
        public void guzergahOtobusSil(GuzergahOtobus guzergahOtobus);
        public void guzergahOtobusGuncelle(GuzergahOtobus guzergahOtobus);
        List<GuzergahOtobus> guzergahOtobusListele();
        public GuzergahOtobus guzergahOtobusGetById(int id);
        public GuzergahOtobus guzergahOtobusGetByDate(DateTime date);
    }
}

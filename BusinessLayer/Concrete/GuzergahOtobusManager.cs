using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;

namespace BusinessLayer
{
    public class GuzergahOtobusManager : IGuzergahOtobusServis
    {
        IGuzergahOtobusDal guzergahOtobusDal;
        public GuzergahOtobusManager(IGuzergahOtobusDal guzergahOtobusDal)
        {
            this.guzergahOtobusDal = guzergahOtobusDal;
        }

        public void guzergahOtobusEkle(GuzergahOtobus guzergahOtobus)
        {
            guzergahOtobusDal.insert(guzergahOtobus);
        }

        public GuzergahOtobus guzergahOtobusGetByDate(DateTime date)
        {
            return guzergahOtobusDal.get(x => x.tarih == date);
        }

        public GuzergahOtobus guzergahOtobusGetById(int id)
        {
            return guzergahOtobusDal.get(x => x.seferId == id);
        }

        public void guzergahOtobusGuncelle(GuzergahOtobus guzergahOtobus)
        {
            guzergahOtobusDal.update(guzergahOtobus);
        }

        public List<GuzergahOtobus> guzergahOtobusListele()
        {
            return guzergahOtobusDal.list();
        }

        public void guzergahOtobusSil(GuzergahOtobus guzergahOtobus)
        {
            guzergahOtobusDal.delete(guzergahOtobus);
        }
    }
}

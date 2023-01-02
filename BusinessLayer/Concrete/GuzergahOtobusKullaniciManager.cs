using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuzergahOtobusKullaniciManager : IGuzergahOtobusKullaniciServis
    {
        IGuzergahOtobusKullaniciDal guzergahOtobusKullaniciDal;
        public GuzergahOtobusKullaniciManager(IGuzergahOtobusKullaniciDal guzergahOtobusKullaniciDal)
        {
            this.guzergahOtobusKullaniciDal = guzergahOtobusKullaniciDal;
        }

        public void BiletEkle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {
            guzergahOtobusKullaniciDal.insert(guzergahOtobusKullanici);
        }


        public GuzergahOtobusKullanici BiletGetById(int id)
        {
            return guzergahOtobusKullaniciDal.get(x => x.biletId == id);
        }


        public void BiletGuncelle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {
            guzergahOtobusKullaniciDal.update(guzergahOtobusKullanici);
        }


        public List<GuzergahOtobusKullanici> BiletListele()
        {
            return guzergahOtobusKullaniciDal.list();
        }


        public void BiletSil(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {
            guzergahOtobusKullaniciDal.delete(guzergahOtobusKullanici); 
        }
    }
}

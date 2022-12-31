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

        public void GuzergahOtobusKullaniciEkle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {
            guzergahOtobusKullaniciDal.insert(guzergahOtobusKullanici);
        }


        public GuzergahOtobusKullanici guzergahOtobusKullaniciGetById(int id)
        {
            return guzergahOtobusKullaniciDal.get(x => x.biletId == id);
        }


        public void GuzergahOtobusKullaniciGuncelle(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {
            guzergahOtobusKullaniciDal.update(guzergahOtobusKullanici);
        }


        public List<GuzergahOtobusKullanici> guzergahOtobusKullaniciListele()
        {
            return guzergahOtobusKullaniciDal.list();
        }


        public void GuzergahOtobusKullaniciSil(GuzergahOtobusKullanici guzergahOtobusKullanici)
        {
            guzergahOtobusKullaniciDal.delete(guzergahOtobusKullanici); 
        }
    }
}

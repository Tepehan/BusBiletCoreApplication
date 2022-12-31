using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGuzergahOtobusKullaniciServis
    {
        void GuzergahOtobusKullaniciEkle(GuzergahOtobusKullanici guzergahOtobusKullanici);
        void GuzergahOtobusKullaniciSil(GuzergahOtobusKullanici guzergahOtobusKullanici);
        void GuzergahOtobusKullaniciGuncelle(GuzergahOtobusKullanici guzergahOtobusKullanici);
        List<GuzergahOtobusKullanici> guzergahOtobusKullaniciListele();
        public GuzergahOtobusKullanici guzergahOtobusKullaniciGetById(int id);
    }
}

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
        void BiletEkle(GuzergahOtobusKullanici guzergahOtobusKullanici);
        void BiletSil(GuzergahOtobusKullanici guzergahOtobusKullanici);
        void BiletGuncelle(GuzergahOtobusKullanici guzergahOtobusKullanici);
        List<GuzergahOtobusKullanici> BiletListele();
        public GuzergahOtobusKullanici BiletGetById(int id);
    }
}

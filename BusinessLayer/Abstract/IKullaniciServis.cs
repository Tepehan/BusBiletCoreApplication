using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKullaniciServis
    {
        void KullaniciEkle(Kullanici kullanici);
        void KullaniciSil(Kullanici kullanici);
        void KullaniciGuncelle(Kullanici kullanici);
        List<Kullanici> KullaniciListele();
        Kullanici KullaniciGetirById(int id);
        Kullanici KullaniciGetirByName(string name);
    }
}

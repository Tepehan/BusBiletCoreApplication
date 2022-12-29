using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IKullaniciServis
    {
        void KullaniciEkle(Kullanici kullanici);
        void KullaniciSil(Kullanici kullanici);
        void KullaniciGüncelle(Kullanici kullanici);
        List<Kullanici> KullaniciListele();
        Kullanici KullaniciGetirById(int id);
        Kullanici KullaniciGetirByName(string name);
    }
}

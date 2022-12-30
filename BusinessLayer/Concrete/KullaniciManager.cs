using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KullaniciManager : IKullaniciServis
    {

        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public void KullaniciEkle(Kullanici kullanici)
        {
            _kullaniciDal.insert(kullanici);
        }

        public Kullanici KullaniciGetirById(int id)
        {
            return _kullaniciDal.get(x => x.kullaniciId == id);

        }

        public Kullanici KullaniciGetirByName(string name)
        {
            return _kullaniciDal.get(x => x.kullaniciAd ==name);
        }

        public void KullaniciGuncelle(Kullanici kullanici)
        {

            _kullaniciDal.update(kullanici);
        }

        public void KullaniciSil(Kullanici kullanici)
        {
            _kullaniciDal.delete(kullanici);
        }

        public List<Kullanici> KullaniciListele()
        {
            return _kullaniciDal.list();
        }
    }
}

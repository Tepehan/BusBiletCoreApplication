using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class FirmaManager : IFirmaServis
    {
        IFirmaDal firmaDal;

        public FirmaManager(IFirmaDal firmaDal)
        {
            this.firmaDal = firmaDal;
        }

        public void firmaEkle(Firma firma)
        {
        
                firmaDal.insert(firma);                    
        }

        public Firma firmaGetirById(int id)
        {
            return firmaDal.get(x=>x.firmaId==id);
        }

        public Firma firmaGetirByName(string ad)
        {
            return firmaDal.get(x => x.firmaAd == ad);
        }

        public void firmaGuncelle(Firma firma)
        {
            firmaDal.update(firma);
        }

        public List<Firma> firmaListele()
        {
            return firmaDal.list();
        }

        public void firmaSil(Firma firma)
        {
            firmaDal.delete(firma);
        }
    }
}

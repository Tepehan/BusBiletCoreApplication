using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IFirmaServis
    {
        void firmaEkle(Firma firma);
        void firmaSil(Firma firma);
        void firmaGuncelle(Firma firma);
        List<Firma> firmaListele();
        Firma firmaGetirById(int id);
        Firma firmaGetirByName(string name);
    }
}

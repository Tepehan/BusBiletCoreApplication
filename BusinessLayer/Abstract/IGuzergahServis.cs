using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGuzergahServis
    {
        void GuzergahEkle(Guzergah guzergah);
        void GuzergahSil(Guzergah guzergah);
        void GuzergahGuncelle(Guzergah guzergah);
        List<Guzergah> GuzergahListele();
        Guzergah GuzergahGetirById(int id);

    }
}

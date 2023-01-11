using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMenuServis
    {
        List<Menu> menuListele();
        void menuEkle(Menu menu);
        void menuGuncelle(Menu menu);
        Menu menuGetirById(int id);
        Menu menuGetirBySeoUrl(String seoUrl);
    }
}

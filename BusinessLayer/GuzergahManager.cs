using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    
    public class GuzergahManager : IGuzergahServis
    {
         IGuzergahDal guzergahDal;
        public GuzergahManager(IGuzergahDal guzergahDal) 
        {
            this.guzergahDal = guzergahDal;
        }
        public void GuzergahEkle(Guzergah guzergah)
        {
            guzergahDal.insert(guzergah);
        }

        public Guzergah GuzergahGetirById(int id)
        {
            return guzergahDal.get(x=>x.guzergahId==id);
        }

        public void GuzergahGuncelle(Guzergah guzergah)
        {
            guzergahDal.update(guzergah);
        }

        public List<Guzergah> GuzergahListele()
        {
            return guzergahDal.list();
        }

        public void GuzergahSil(Guzergah guzergah)
        {

            guzergahDal.delete(guzergah);
        }
    }
}

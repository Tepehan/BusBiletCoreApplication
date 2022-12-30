using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class OtobusManager : IOtobusServis
	{
		IOtobusDal otobusDal;
		public OtobusManager(IOtobusDal otobusDal) 
		{
			this.otobusDal= otobusDal;
		}
		public void otobusEkle(Otobus otobus)
		{
			otobusDal.insert(otobus);
		}

		public Otobus otobusGetirByFirmaId(int firmaId)
		{
			return otobusDal.get(x => x.firmaId == firmaId);
		}

		public Otobus otobusGetirById(int id)
		{
			return otobusDal.get(x => x.otobusId == id);
		}

		public Otobus otobusGetirByMarka(string marka)
		{
			return otobusDal.get(x=>x.marka==marka);	
		}

		public void otobusGuncelle(Otobus otobus)
		{
			otobusDal.update(otobus);
		}
		public List<Otobus> otobusListele()
		{
			return otobusDal.list();
		}

		public void otobusSil(Otobus otobus)
		{
			otobusDal.delete(otobus);
		}
	}
}

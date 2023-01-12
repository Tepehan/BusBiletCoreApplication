using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            this.sliderDal = sliderDal;
        }

        public void sliderEkle(Slider slider)
        {
            sliderDal.insert(slider);
        }

        public Slider sliderGetirById(int id)
        {
            return sliderDal.get(slider=>slider.sliderId==id);
        }

        public void sliderGuncelle(Slider slider)
        {
            sliderDal.update(slider);

        }

        public List<Slider> SliderListele()
        {
            return sliderDal.list();
        }
    }
}

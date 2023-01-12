using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISliderService
    {
        List<Slider> SliderListele();
        void sliderEkle(Slider slider);
        void sliderGuncelle(Slider slider);
        Slider sliderGetirById(int id);
      
    }
}

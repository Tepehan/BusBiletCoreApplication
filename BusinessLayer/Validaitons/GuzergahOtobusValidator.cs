using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validaitons
{
    public class GuzergahOtobusValidator : AbstractValidator<GuzergahOtobus>
    {
        public GuzergahOtobusValidator()
        {
            //Süre
            RuleFor(guzergahOtobus => guzergahOtobus.sure).NotEmpty().WithMessage("Süre boş geçilemez !");

            //Kalkış Saat
            RuleFor(guzergahOtobus => guzergahOtobus.kalkisSaat).NotEmpty().WithMessage("Kalkış saati boş geçilemez !");
            RuleFor(guzergahOtobus => guzergahOtobus.kalkisSaat).MaximumLength(5).WithMessage("Maksimum 5 karakter girebilirsiniz !");
            RuleFor(guzergahOtobus => guzergahOtobus.kalkisSaat).MinimumLength(5).WithMessage("Minimum 5 karakter girebilirsiniz !");

            //Tarih
            RuleFor(guzergahOtobus => guzergahOtobus.tarih).NotEmpty().WithMessage("Tarih boş geçilemez !");

            //Bilet Fiyat
            RuleFor(guzergahOtobus => guzergahOtobus.biletFiyat).NotEmpty().WithMessage("Bilet fiyatı boş geçilemez !");
            RuleFor(guzergahOtobus => guzergahOtobus.biletFiyat).GreaterThan(0.00).WithMessage("Daha yüksek fiyat girmelisiniz !");

        }
    }
}

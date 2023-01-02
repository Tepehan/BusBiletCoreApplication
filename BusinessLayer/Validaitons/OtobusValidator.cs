using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validaitons
{
    public class OtobusValidator: AbstractValidator<Otobus>
    {
        public OtobusValidator() 
        {
			//Rule for KoltukSayisi
			RuleFor(otobus => otobus.koltukSayisi).NotEmpty().WithMessage("Boş geçilemez");
			//Rule for Plaka
			RuleFor(otobus => otobus.plaka).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(otobus => otobus.plaka).MaximumLength(9).WithMessage("Maximum 9 karakter girilebilir.");
            RuleFor(otobus => otobus.plaka).MinimumLength(5).WithMessage("Minimum 5 karakter girilmedilir.");

            //Rule for Marka
            RuleFor(otobus => otobus.marka).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(otobus => otobus.marka).MaximumLength(50).WithMessage("Maximum 50 karakter girilebilir.");
            RuleFor(otobus => otobus.marka).MinimumLength(3).WithMessage("Minimum 3 karakter girilmedilir.");
            //Rule for Model
            RuleFor(otobus => otobus.model).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(otobus => otobus.model).MaximumLength(50).WithMessage("Maximum 50 karakter girilebilir.");
            RuleFor(otobus => otobus.model).MinimumLength(3).WithMessage("Minimum 3 karakter girilmedilir.");
        }
    }
}

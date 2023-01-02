using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validaitons
{
    public class GuzergahValidator: AbstractValidator<Guzergah>
    {
        public GuzergahValidator() 
        {
            //Rule for GuzergahKalkisYeri
            RuleFor(guzergah => guzergah.kalkisYeri).NotEmpty().WithMessage("Boş geçilmez");
            RuleFor(guzergah => guzergah.kalkisYeri).MaximumLength(20).WithMessage("Maximum 50 karekter girilebilir");
            RuleFor(guzergah => guzergah.kalkisYeri).MinimumLength(3).WithMessage("Minimum 3 karakter girilebilir");
            //Rule for GuzergahVarısYeri
            RuleFor(guzergah => guzergah.varisYeri).NotEmpty().WithMessage("Boş geçilmez");
            RuleFor(guzergah => guzergah.varisYeri).MaximumLength(20).WithMessage("Maximum 50 karekter girilebilir");
            RuleFor(guzergah => guzergah.varisYeri).MinimumLength(3).WithMessage("Minimum 3 karakter girilebilir");
        }  

    }
}

using EntityLayer;
using FluentValidation;

namespace BusBiletCoreApplication.Validaitons
{
    public class FirmaValidator: AbstractValidator<Firma>
    {
        public FirmaValidator()
        {   
            //Rule for FirmaAd
            RuleFor(firma => firma.firmaAd).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(firma => firma.firmaAd).MaximumLength(50).WithMessage("Maximum 50 karakter girilmelidir.");
            RuleFor(firma => firma.firmaAd).MinimumLength(2).WithMessage("Minimum 2 karakter girilmelidir.");

            //Rule for iletişim
            RuleFor(firma => firma.iletisim).MaximumLength(300).WithMessage("Maximum 300 karakter girilmelidir.");

            //Rule for logo
            RuleFor(firma => firma.logoUrl).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(firma => firma.logoUrl).MaximumLength(100).WithMessage("Maximum 100 karakter girilmelidir.");
            RuleFor(firma => firma.logoUrl).MinimumLength(1).WithMessage("Minimum 1 karakter girilmelidir.");


        }
    }
}

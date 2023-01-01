using EntityLayer;
using FluentValidation;

namespace BusBiletCoreApplication.Validaitons
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            //Rule for KullaniciAd
            RuleFor(kullanici => kullanici.kullaniciAd).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(kullanici => kullanici.kullaniciAd).MaximumLength(50).WithMessage("Maximum 50 karakter girilmelidir.");
            RuleFor(kullanici => kullanici.kullaniciAd).MinimumLength(2).WithMessage("Minimum 2 karakter girilmelidir.");

            //Rule for KullaniciSifre
            RuleFor(kullanici => kullanici.kullaniciSifre).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(kullanici => kullanici.kullaniciSifre).MaximumLength(50).WithMessage("Maximum 50 karakter girilmelidir.");
            RuleFor(kullanici => kullanici.kullaniciSifre).MinimumLength(2).WithMessage("Minimum 2 karakter girilmelidir.");

            //Rule for  ad
            RuleFor(kullanici => kullanici.ad).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(kullanici => kullanici.ad).MaximumLength(50).WithMessage("Maximum 50 karakter girilmelidir.");
            RuleFor(kullanici => kullanici.ad).MinimumLength(2).WithMessage("Minimum 2 karakter girilmelidir.");

            //Rule for  Soyad
            RuleFor(kullanici => kullanici.soyad).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(kullanici => kullanici.soyad).MaximumLength(50).WithMessage("Maximum 50 karakter girilmelidir.");
            RuleFor(kullanici => kullanici.soyad).MinimumLength(2).WithMessage("Minimum 2 karakter girilmelidir.");

            //Rule for  dogumTarihi
            RuleFor(kullanici => kullanici.dogumTarihi).NotEmpty().WithMessage("Boş geçilemez.");
            
            //Rule for  tc
            RuleFor(kullanici => kullanici.tc).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(kullanici => kullanici.tc).MaximumLength(11).WithMessage("Maximum 11 karakter girilmelidir.");
            RuleFor(kullanici => kullanici.tc).MinimumLength(5).WithMessage("Minimum 5 karakter girilmelidir.");

            //Rule for cinsiyet
            RuleFor(kullanici => kullanici.cinsiyet).NotNull().WithMessage("Cinsiyet Gereklidir.");

            //Rule for mail
            RuleFor(kullanici => kullanici.mail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(kullanici => kullanici.mail).MaximumLength(50).WithMessage("Maximum 50 karakter girilmelidir.");
            RuleFor(kullanici => kullanici.mail).MinimumLength(2).WithMessage("Minimum 2 karakter girilmelidir.");

            //Rule for  tel
            RuleFor(kullanici => kullanici.tel).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(kullanici => kullanici.tel).MaximumLength(11).WithMessage("Maximum 11 karakter girilmelidir.");
            RuleFor(kullanici => kullanici.tel).MinimumLength(5).WithMessage("Minimum 5  karakter girilmelidir.");

        }
    }
}

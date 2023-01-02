using EntityLayer;
using FluentValidation;


namespace BusinessLayer.Validaitons
{
    public class GuzergahOtobusKullaniciValidator:AbstractValidator<GuzergahOtobusKullanici>
    {
        public GuzergahOtobusKullaniciValidator()
        {
            //Rule For SeriNo
            RuleFor(guzergahOtobusKullanici=>guzergahOtobusKullanici.seriNo).NotEmpty().WithMessage("Seri No Boş geçilemez.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.seriNo).MaximumLength(50).WithMessage("Maksimum 50 karakter girebilirsiniz.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.seriNo).MinimumLength(4).WithMessage("Minimum 4 karakter girebilirsiniz.");

            //Rule For KoltukNo
            RuleFor(guzergahOtobusKullanici=>guzergahOtobusKullanici.koltukNo).NotEmpty().WithMessage("Koltuk No boş geçilemez.");

            //Rule For BiletKesimTarihi
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.biletKesimTarihi).NotEmpty().WithMessage("Bilet kesim tarihi boş geçilemez.");

            //Rule For YolcuAd
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuAd).NotEmpty().WithMessage("Yolcu Ad Boş geçilemez.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuAd).MaximumLength(25).WithMessage("Maksimum 25 karakter girebilirsiniz.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuAd).MinimumLength(2).WithMessage("Minimum 2 karakter girebilirsiniz.");

            //Rule For YolcuSoyad
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuSoyad).NotEmpty().WithMessage("Yolcu Soyad Boş geçilemez.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuSoyad).MaximumLength(25).WithMessage("Maksimum 25 karakter girebilirsiniz.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuSoyad).MinimumLength(2).WithMessage("Minimum 2 karakter girebilirsiniz.");

            //Rule For YolcuTc
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuTc).NotEmpty().WithMessage("Yolcu Tc Boş geçilemez.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuTc).MaximumLength(11).WithMessage("Maksimum 11 karakter girebilirsiniz.");
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.yolcuTc).MinimumLength(11).WithMessage("Minimum 11 karakter girebilirsiniz.");

            //Rule For seferId
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.seferId).NotEmpty().WithMessage("sefer Id tarihi boş geçilemez.");

            //Rule For kullaniciId
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.kullaniciId).NotEmpty().WithMessage("kullanici Id tarihi boş geçilemez.");
        }
    }
}

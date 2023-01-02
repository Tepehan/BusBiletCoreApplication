using EntityLayer;
using FluentValidation;


namespace BusinessLayer.Validaitons
{
    public class GuzergahOtobusKullaniciValidator:AbstractValidator<GuzergahOtobusKullanici>
    {
        public GuzergahOtobusKullaniciValidator()
        {
            //Rule For SeriNo
            RuleFor(bilet=> bilet.seriNo).NotEmpty().WithMessage("Seri No Boş geçilemez.");
            RuleFor(bilet => bilet.seriNo).MaximumLength(50).WithMessage("Maksimum 50 karakter girebilirsiniz.");
            RuleFor(bilet => bilet.seriNo).MinimumLength(4).WithMessage("Minimum 4 karakter girebilirsiniz.");

            //Rule For KoltukNo
            RuleFor(bilet => bilet.koltukNo).NotEmpty().WithMessage("Koltuk No boş geçilemez.");

            //Rule For BiletKesimTarihi
            RuleFor(bilet => bilet.biletKesimTarihi).NotEmpty().WithMessage("Bilet kesim tarihi boş geçilemez.");

            //Rule For YolcuAd
            RuleFor(bilet => bilet.yolcuAd).NotEmpty().WithMessage("Yolcu Ad Boş geçilemez.");
            RuleFor(bilet => bilet.yolcuAd).MaximumLength(25).WithMessage("Maksimum 25 karakter girebilirsiniz.");
            RuleFor(bilet => bilet.yolcuAd).MinimumLength(2).WithMessage("Minimum 2 karakter girebilirsiniz.");

            //Rule For YolcuSoyad
            RuleFor(bilet => bilet.yolcuSoyad).NotEmpty().WithMessage("Yolcu Soyad Boş geçilemez.");
            RuleFor(bilet => bilet.yolcuSoyad).MaximumLength(25).WithMessage("Maksimum 25 karakter girebilirsiniz.");
            RuleFor(bilet => bilet.yolcuSoyad).MinimumLength(2).WithMessage("Minimum 2 karakter girebilirsiniz.");

            //Rule For YolcuTc
            RuleFor(bilet => bilet.yolcuTc).NotEmpty().WithMessage("Yolcu Tc Boş geçilemez.");
            RuleFor(bilet => bilet.yolcuTc).MaximumLength(11).WithMessage("Maksimum 11 karakter girebilirsiniz.");
            RuleFor(bilet => bilet.yolcuTc).MinimumLength(11).WithMessage("Minimum 11 karakter girebilirsiniz.");

            //Rule For seferId
            RuleFor(bilet => bilet.seferId).NotEmpty().WithMessage("sefer Id tarihi boş geçilemez.");

            //Rule For kullaniciId
            RuleFor(bilet => bilet.kullaniciId).NotEmpty().WithMessage("kullanici Id tarihi boş geçilemez.");
        }
    }
}

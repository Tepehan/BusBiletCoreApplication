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
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.seriNo).MinimumLength(2).WithMessage("Minimum 2 karakter girebilirsiniz.");

            //Rule For KoltukNo
            RuleFor(guzergahOtobusKullanici=>guzergahOtobusKullanici.koltukNo).NotEmpty().WithMessage("Koltuk No boş geçilemez.");

            //Rule For BiletKesimTarihi
            RuleFor(guzergahOtobusKullanici => guzergahOtobusKullanici.biletKesimTarihi).NotEmpty().WithMessage("Bilet kesim tarihi boş geçilemez.");          

            
        }
    }
}

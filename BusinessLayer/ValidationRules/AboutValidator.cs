using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Resim kısmını boş geçemezsiniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama karakter sayısı 50'den az olamaz");
			RuleFor(x => x.Description).MaximumLength(1250).WithMessage("Açıklama karakter sayısı 1250'den fazla olamaz");

        }
	}
}


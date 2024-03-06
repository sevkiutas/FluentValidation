using FluentValidation;
using ValidationTestApp.Models;

namespace ValidationTestApp.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Ad alanı boş geçilemez!").Must(BeStringOnly).WithMessage("Bu alan sadece yazı içermelidir."); ;
            RuleFor(x => x.Email).NotNull().WithMessage("Mail alanı boş geçilemez!").EmailAddress().WithMessage("Geçerli bir mail adresi giriniz!");
            RuleFor(x => x.Phone).NotNull().WithMessage("Telefon alanı boş geçilemez!").Length(0, 11).WithMessage("Telefon Numarası 11 karakterden uzun olamaz");
        }

        private bool BeStringOnly(string value)
        {
             return !string.IsNullOrEmpty(value) && value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }
    }
}

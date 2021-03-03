using FluentValidation;
using ToDoApp.DTO.DTOs.AppUserDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class AppUserAddValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddValidator()
        {
            RuleFor(I=>I.UserName).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(I=>I.Password).NotNull().WithMessage("Parola alanı boş geçilemez");
            RuleFor(I=>I.ConfirmPassword).NotNull().WithMessage("Parola onay alanı boş geçilemez");
            RuleFor(I=>I.ConfirmPassword).Equal(I=>I.Password).WithMessage("Parolalar eşleşmiyor");
            RuleFor(I=>I.Email).NotNull().WithMessage("Email alanı boş geçilemez").EmailAddress().WithMessage("Geçersiz email adresi");
            RuleFor(I=>I.Name).NotNull().WithMessage("Isim alanı boş geçilemez");
            RuleFor(I=>I.SurName).NotNull().WithMessage("Soyisim alanı boş geçilemez");
            

        }
    }
}
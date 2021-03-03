using FluentValidation;
using ToDoApp.DTO.DTOs.AppUserDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class AppUserSignInValidator : AbstractValidator<AppUserSignInDto>
    {
        public AppUserSignInValidator()
        {
            RuleFor(I=>I.UserName).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(I=>I.Password).NotNull().WithMessage("Şifre alanı boş geçilemez");
        }
    }
}
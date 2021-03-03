using FluentValidation;
using ToDoApp.DTO.DTOs.GorevDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class GorevUpdateValidator : AbstractValidator<GorevUpdateDto>
    {
        public GorevUpdateValidator()
        {
            RuleFor(I=>I.Ad).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(I=>I.AciliyetId).ExclusiveBetween(0,int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}
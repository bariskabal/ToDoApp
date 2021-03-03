using FluentValidation;
using ToDoApp.DTO.DTOs.GorevDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class GorevAddValidator : AbstractValidator<GorevAddDto>
    {
        public GorevAddValidator()
        {
            RuleFor(I=>I.Ad).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(I=>I.AciliyetId).ExclusiveBetween(0,int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}
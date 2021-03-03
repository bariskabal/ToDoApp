using FluentValidation;
using ToDoApp.DTO.DTOs.RaporDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class RaporAddValidator : AbstractValidator<RaporAddDto>
    {
        public RaporAddValidator()
        {
            RuleFor(I=>I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(I=>I.Detay).NotNull().WithMessage("Detay alanı boş geçilemez");
            
        }
    }
}
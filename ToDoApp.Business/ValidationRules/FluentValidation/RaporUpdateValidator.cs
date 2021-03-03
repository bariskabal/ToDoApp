using FluentValidation;
using ToDoApp.DTO.DTOs.RaporDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class RaporUpdateValidator :AbstractValidator<RaporUpdateDto>
    {
        public RaporUpdateValidator()
        {
            RuleFor(I=>I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(I=>I.Detay).NotNull().WithMessage("Detay alanı boş geçilemez");
            
        }   
    }
}
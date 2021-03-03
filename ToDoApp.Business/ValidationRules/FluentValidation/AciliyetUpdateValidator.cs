using FluentValidation;
using ToDoApp.DTO.DTOs.AciliyetDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class AciliyetUpdateValidator : AbstractValidator<AciliyetUpdateDto>
    {
        public AciliyetUpdateValidator()
        {
            RuleFor(I=>I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
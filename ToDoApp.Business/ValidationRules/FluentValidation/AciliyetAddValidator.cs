using FluentValidation;
using ToDoApp.DTO.DTOs.AciliyetDtos;

namespace ToDoApp.Business.ValidationRules.FluentValidation
{
    public class AciliyetAddValidator : AbstractValidator<AciliyetAddDto>
    {
        public AciliyetAddValidator()
        {
            RuleFor(I=>I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
using CorePackages.Entities.DTOs;
using FluentValidation;

namespace Battery.Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.CellSerialNo).NotNull().WithMessage("{PropertyCellSerialNo} is required").NotEmpty().WithMessage("{PropertyCellSerialNo} is required");
        }
    }
}

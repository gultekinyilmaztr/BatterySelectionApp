using CorePackages.Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

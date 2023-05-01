using FluentValidation;
using netCore.FluentValidation.Models;
using static netCore.FluentValidation.Constants.ProductMessage;
namespace netCore.FluentValidation.FluentValidations.Products
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(NameIsRequired);
            RuleFor(x => x.Name)
                .Length(3, 50)
                .WithMessage(NameLength);
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage(DescriptionIsRequired);
            RuleFor(x => x.Description)
                .Length(3, 20)
                .WithMessage(DescriptionLength);
            RuleFor(x => x.Price)
                .NotEmpty()
                .WithMessage(PriceIsRequired)
                .GreaterThan(0)
                .WithMessage(PriceGreaterThan);

        }
    }
}

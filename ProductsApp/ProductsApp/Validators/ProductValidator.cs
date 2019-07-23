using FluentValidation;

namespace ProductsApp.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(4);
        }
    }
}

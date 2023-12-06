using FlowTime.WebAPI.Models;
using FluentValidation;

namespace FlowTime.WebAPI.Validators
{
    public class CreateUserRequestModelValidator : AbstractValidator<CreateUserRequestModel>
    {
        public CreateUserRequestModelValidator()
        {
            RuleFor(model => model.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(model => model.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(model => model.Country).NotEmpty().WithMessage("Country is required.");
            RuleFor(model => model.City).NotEmpty().WithMessage("City is required.");
            RuleFor(model => model.WorkTime).GreaterThan(0).WithMessage("Work time should be greater than 0.");

            // Diğer kuralları ekleyin
        }
    }
}

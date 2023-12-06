using FlowTime.Domain.Entities;
using FluentValidation;

namespace FlowTime.WebAPI.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(user => user.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(user => user.Country).NotEmpty().WithMessage("Country is required.");
            RuleFor(user => user.City).NotEmpty().WithMessage("City is required.");
            RuleFor(user => user.WorkTime).GreaterThan(0).WithMessage("Work time should be greater than 0.");
            
        }
    }
}

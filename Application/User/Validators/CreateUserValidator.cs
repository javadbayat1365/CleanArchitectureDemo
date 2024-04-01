using Application.User.Commands;
using FluentValidation;

namespace Application.User.Validators;

public class CreateUserValidator:AbstractValidator<CreateUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(x =>x.Name).NotNull().NotEmpty().MaximumLength(20);
        RuleFor(x =>x.Email).NotNull().NotEmpty();
        RuleFor(x =>x.Family).NotNull();
    }
}

using FluentValidation;

namespace BLL.Mediatr.Users.Commands.CreateUserCommand;
public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(m => m.Name).NotNull().NotEmpty();
        RuleFor(m => m.Surname).NotNull().NotEmpty();
    }
}
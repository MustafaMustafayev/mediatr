using FluentValidation;

namespace BLL.Mediatr.Users.Commands.UpdateUserCommand;
public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(m => m.Id).GreaterThan(0);
        RuleFor(m => m.Name).NotNull().NotEmpty();
        RuleFor(m => m.Surname).NotNull().NotEmpty();
    }
}
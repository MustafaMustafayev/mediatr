using Core.Models;
using FluentValidation;

namespace BLL.Mediatr.Roles.Commands.CreateRoleCommand;
public class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
    public CreateRoleCommandValidator()
    {
        RuleFor(m => m.Name).NotEmpty().NotNull();
        RuleFor(m => m.Key).NotEmpty().NotNull();
    }
}
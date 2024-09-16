using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mediatr.Roles.Commands.UpdateRoleCommand;
public class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
{
    public UpdateRoleCommandValidator()
    {
        RuleFor(m => m.Id).GreaterThan(0);
        RuleFor(m => m.Name).NotNull().NotEmpty();
        RuleFor(m => m.Key).NotNull().NotEmpty();
    }
}

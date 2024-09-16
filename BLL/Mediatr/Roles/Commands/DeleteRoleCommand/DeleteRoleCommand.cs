using MediatR;

namespace BLL.Mediatr.Roles.Commands.DeleteRoleCommand;
public record DeleteRoleCommand : IRequest
{
    public int Id { get; set; }
}

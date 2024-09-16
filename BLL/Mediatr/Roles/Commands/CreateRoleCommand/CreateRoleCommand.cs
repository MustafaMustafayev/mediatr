using DTO.Roles;
using MediatR;

namespace BLL.Mediatr.Roles.Commands.CreateRoleCommand;
public record CreateRoleCommand : IRequest
{
    public string Name { get; set; } = default!;
    public string Key { get; set; } = default!;
}

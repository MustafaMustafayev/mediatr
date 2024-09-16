using MediatR;

namespace BLL.Mediatr.Roles.Commands.UpdateRoleCommand;
public record UpdateRoleCommand : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Key { get; set; } = default!;
}
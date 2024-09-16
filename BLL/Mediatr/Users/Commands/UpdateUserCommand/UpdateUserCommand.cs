using MediatR;

namespace BLL.Mediatr.Users.Commands.UpdateUserCommand;
public record UpdateUserCommand : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
}

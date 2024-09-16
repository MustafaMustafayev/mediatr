using MediatR;

namespace BLL.Mediatr.Users.Commands.DeleteUserCommand;
public record DeleteUserCommand : IRequest
{
    public int Id { get; set; }
}

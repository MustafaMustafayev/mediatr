using DTO.Users;
using MediatR;

namespace BLL.Mediatr.Users.Commands.CreateUserCommand;
public record CreateUserCommand : IRequest<CreateUserResponseDto>
{
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
}

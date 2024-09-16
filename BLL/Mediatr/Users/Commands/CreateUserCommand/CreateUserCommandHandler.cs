using BLL.Mediatr.Users.Queries;
using Core.Models;
using Core.Persistence;
using DTO.Users;
using MediatR;

namespace BLL.Mediatr.Users.Commands.CreateUserCommand;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponseDto>
{
    public async Task<CreateUserResponseDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var newId = Datas.Users.Max(m => m.Id) + 1;

        User user = new User()
        {
            Id = newId,
            Name = request.Name,
            Surname = request.Surname
        };

        Datas.Users.Add(user);

        return await Task.FromResult(new CreateUserResponseDto() { Id = newId });
    }
}

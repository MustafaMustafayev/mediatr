using Core.Models;
using Core.Persistence;
using DTO.Roles;
using MediatR;

namespace BLL.Mediatr.Roles.Commands.CreateRoleCommand;
public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand>
{
    public async Task Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        int maxId = Datas.Roles.Any() ? Datas.Roles.Max(m => m.Id) : 0;
        int newId = maxId + 1;

        Role role = new()
        {
            Id = newId,
            Name = request.Name,
            Key = request.Key
        };

        Datas.Roles.Add(role);
    }
}

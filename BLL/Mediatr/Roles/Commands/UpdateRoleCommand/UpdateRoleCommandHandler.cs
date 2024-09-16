using Core.Persistence;
using MediatR;

namespace BLL.Mediatr.Roles.Commands.UpdateRoleCommand;
public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
{
    public async Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = Datas.Roles.Find(m => m.Id == request.Id);
        role.Name = request.Name;
        role.Key = request.Key;
    }
}

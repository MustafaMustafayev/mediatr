using Core.Persistence;
using MediatR;

namespace BLL.Mediatr.Roles.Commands.DeleteRoleCommand;
public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
{
    public async Task Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        var role = Datas.Roles.Find(m => m.Id == request.Id);
        Datas.Roles.Remove(role);
    }
}

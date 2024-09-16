using Core.Persistence;
using MediatR;

namespace BLL.Mediatr.Users.Commands.DeleteUserCommand;
public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
{
    public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var user = Datas.Users.Find(m => m.Id == request.Id);
        Datas.Users.Remove(user);
    }
}

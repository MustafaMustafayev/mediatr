using Core.Persistence;
using MediatR;

namespace BLL.Mediatr.Users.Commands.UpdateUserCommand;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
{
    public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = Datas.Users.Find(m => m.Id == request.Id);
        user.Name = request.Name;
        user.Surname = request.Surname;
    }
}

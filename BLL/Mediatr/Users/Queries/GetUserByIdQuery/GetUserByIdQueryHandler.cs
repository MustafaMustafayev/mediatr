using Core.Persistence;
using DTO.Users;
using MediatR;

namespace BLL.Mediatr.Users.Queries.GetUserByIdQuery;
public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserByIdResponseDto>
{
    public Task<UserByIdResponseDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = Datas.Users.Find(m => m.Id == request.Id);
        var response = new UserByIdResponseDto()
        {
            Id = user.Id,
            Name = user.Name,
            Surname = user.Surname
        };

        return Task.FromResult(response);
    }
}

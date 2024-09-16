using Core.Persistence;
using DTO.Users;
using MediatR;

namespace BLL.Mediatr.Users.Queries.GetAllUsersQuery;
public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserGetAllResponseDto>>
{
    public async Task<List<UserGetAllResponseDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = Datas.Users;

        List<UserGetAllResponseDto> dtos = new();

        foreach (var user in users)
        {
            UserGetAllResponseDto dto = new()
            {
                Id = user.Id,
                Name = user.Name
            };

            dtos.Add(dto);
        }

        return await Task.FromResult(dtos);
    }
}

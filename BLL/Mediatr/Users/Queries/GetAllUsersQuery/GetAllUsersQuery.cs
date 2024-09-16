using DTO.Users;
using MediatR;

namespace BLL.Mediatr.Users.Queries.GetAllUsersQuery;
public record GetAllUsersQuery : IRequest<List<UserGetAllResponseDto>>
{
}

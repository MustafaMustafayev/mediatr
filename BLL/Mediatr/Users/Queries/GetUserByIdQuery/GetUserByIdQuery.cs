using DTO.Users;
using MediatR;

namespace BLL.Mediatr.Users.Queries.GetUserByIdQuery;
public record GetUserByIdQuery : IRequest<UserByIdResponseDto>
{
    public int Id { get; set; }
}

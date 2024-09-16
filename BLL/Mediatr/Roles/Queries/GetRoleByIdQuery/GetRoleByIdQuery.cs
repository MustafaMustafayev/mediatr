using DTO.Roles;
using MediatR;

namespace BLL.Mediatr.Roles.Queries.GetRoleByIdQuery;
public record GetRoleByIdQuery : IRequest<RoleByIdResponseDto>
{
    public int Id { get; set; }
}

using DTO.Roles;
using MediatR;

namespace BLL.Mediatr.Roles.Queries.GetAllRolesQuery;
public record GetAllRolesQuery : IRequest<List<RoleGetAllResponseDto>>
{
}

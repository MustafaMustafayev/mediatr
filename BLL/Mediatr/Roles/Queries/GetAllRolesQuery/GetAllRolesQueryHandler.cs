using Core.Persistence;
using DTO.Roles;
using MediatR;

namespace BLL.Mediatr.Roles.Queries.GetAllRolesQuery;
public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, List<RoleGetAllResponseDto>>
{
    public async Task<List<RoleGetAllResponseDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        var roles = Datas.Roles;
        List<RoleGetAllResponseDto> dtos = new();
        foreach (var role in roles)
        {
            RoleGetAllResponseDto dto = new()
            {
                Id = role.Id,
                Name = role.Name
            };

            dtos.Add(dto);
        }

        return await Task.FromResult(dtos);
    }
}

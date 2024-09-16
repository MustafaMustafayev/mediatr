using Core.Persistence;
using DTO.Roles;
using MediatR;

namespace BLL.Mediatr.Roles.Queries.GetRoleByIdQuery;
public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQuery, RoleByIdResponseDto>
{
    public async Task<RoleByIdResponseDto> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
    {
        var role = Datas.Roles.Find(m => m.Id == request.Id);
        RoleByIdResponseDto dto = new()
        {
            Id = role.Id,
            Name = role.Name,
            Key = role.Key
        };

        return await Task.FromResult(dto);
    }
}

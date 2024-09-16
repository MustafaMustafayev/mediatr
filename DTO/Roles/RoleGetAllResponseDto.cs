namespace DTO.Roles;
public record RoleGetAllResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
}

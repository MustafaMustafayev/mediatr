namespace DTO.Roles;
public record RoleByIdResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Key { get; set; } = default!;
}

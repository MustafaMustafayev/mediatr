namespace DTO.Users;
public record UserGetAllResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
}

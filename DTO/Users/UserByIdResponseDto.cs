namespace DTO.Users;
public record UserByIdResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
}

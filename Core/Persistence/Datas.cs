using Core.Models;

namespace Core.Persistence;
public static class Datas
{
    public static List<User> Users = new()
    {
        new User { Id = 1, Name = "name 1", Surname = "surname 1" },
        new User { Id = 2, Name = "name 2", Surname = "surname 2" },
        new User { Id = 3, Name = "name 3", Surname = "surname 3" },
    };

    public static List<Role> Roles = new();
}

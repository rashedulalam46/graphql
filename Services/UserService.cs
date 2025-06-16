using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Models;

namespace GraphQL.Services
{

    public class UserService
    {
         private readonly List<User> _users = new()
    {
        new User { Id = 1, Username = "Rashedul Alam", Email = "rashed@example.com" },
        new User { Id = 2, Username = "John Doe", Email = "john@example.com" }
    };

    public IEnumerable<User> GetUsers() => _users;
    public User? GetUserById(int id) => _users.FirstOrDefault(u => u.Id == id);
    }
}
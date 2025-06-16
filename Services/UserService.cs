using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Models;

namespace GraphQL.Services
{

    public class UserService
    {
         private readonly List<User> _users = new()
    {
        new User { UserId = 1001, UserName = "RASHED", Email = "rashed@example.com" },
        new User { UserId = 1002, UserName = "JOHN", Email = "john@example.com" },
        new User { UserId = 1003, UserName = "KAMAL", Email = "kamal@gmail.com"},
        new User { UserId = 1004, UserName = "KEVIN", Email = "kevin@gmail.com" },
        new User { UserId = 1005, UserName = "MAIKEL", Email = "maikel@gmail.com" }
    };

    public IEnumerable<User> GetUsers() => _users;
    public User? GetUserById(int id) => _users.FirstOrDefault(u => u.UserId == id);
    }
}
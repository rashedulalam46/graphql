using GraphQL.Models;
using GraphQL.Services;

namespace GraphQL.Queries;

public class UserQuery
{
    public IEnumerable<User> GetUsers([Service] UserService service) => service.GetUsers();

    public User? GetUserById(int id, [Service] UserService service) => service.GetUserById(id);
}

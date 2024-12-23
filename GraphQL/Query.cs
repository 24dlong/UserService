namespace UserService.GraphQL;

using UserService.Models;
using UserService.Data;

public class Query
{
    private readonly IUserRepository _userRepository;

    public Query(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User GetUser(int id) =>
        _userRepository.GetUser(id);

    public IEnumerable<User> GetUsers() =>
        _userRepository.ListUsers();
}

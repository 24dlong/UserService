namespace UserService.Data;

using UserService.Models;
using UserService.Dtos;

public class UserRepository : IUserRepository
{
    private static SortedDictionary<int, User> _users = new SortedDictionary<int, User>()
    {
        {1, new User() {Id = 1, Name = "Devon Darling"}},
        {2, new User() {Id = 2, Name = "Daniel Long"}},
        {3, new User() {Id = 3, Name = "Enzo Zanchettin"}},
        {4, new User() {Id = 4, Name = "Esther Silva"}},
        {5, new User() {Id = 5, Name = "Arthur Alberge"}},
    };

    public IEnumerable<User> ListUsers()
    {
        return _users.Values;
    }

    public User GetUser(int id)
    {
        return _users[id];
    }
    
    public User CreateUser(UserToCreateDto user)
    {
        int newId = _users.Count + 1;
        User newUser = new User() {Id = newId, Name = user.Name};
        _users.Add(newId, newUser);
        
        return newUser;
    }
}
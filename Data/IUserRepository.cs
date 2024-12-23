namespace UserService.Data;

using UserService.Models;
using UserService.Dtos;

public interface IUserRepository 
{
    public IEnumerable<User> ListUsers();
    public User GetUser(int id);
    public User CreateUser(UserToCreateDto user);
}
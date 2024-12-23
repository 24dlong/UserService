using Microsoft.AspNetCore.Mvc;
using UserService.Models;
using UserService.Dtos;
using UserService.Data;

namespace UserService.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("")]
    public IEnumerable<User> ListUsers()
    {
        return _userRepository.ListUsers();
    }
    
    [HttpGet("{id}")]
    public User GetUser(int id)
    {
        return _userRepository.GetUser(id);
    }

    [HttpPost("")]
    public User CreateUser(UserToCreateDto userToCreate)
    {
        return _userRepository.CreateUser(userToCreate);
    }

}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Amanda.Application.Models;
using Amanda.Application.Services.UserServices;
namespace Amanda.Api.Controllers;


[ApiController]
[Route("[controller]")]  
public class UserController : ControllerBase
{

    private readonly IUserService _userInterface;

    public UserController(IUserService userService)
    {
        _userInterface = userService;
    }


    [HttpGet("/users/")]
    public async Task<ActionResult<IEnumerable<UserRequestModel>>> GetAllUserAsync(){

        var users = await _userInterface.GetAllUsersAsync();
        return Ok(users);
    }


    [HttpPost("/users/")]
    public async Task<ActionResult<UserResponseModel>> CreateUserAsync(UserResponseModel request){
        var createUsers = await _userInterface.CreateUserAsync(request);
        return Ok(createUsers);
    }

    
}

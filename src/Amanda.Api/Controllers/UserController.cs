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
    public async Task<ActionResult<IAsyncEnumerable<UserRequestModel>>> GetAllUserAsync(){

        var users = await _userInterface.GetAllUsersAsync();
        return Ok(users);
    }


    [HttpPost("/users/")]
    public async Task<ActionResult<UserResponseModel>> CreateUserAsync(UserRequestModel request){
        var createUsers = await _userInterface.CreateUserAsync(request);
        return Ok(createUsers);
    }

    [HttpGet("/users/{id}")]
    public async Task<IActionResult> GetUserByIdAsync(int id)
    {
        var user = await _userInterface.GetUserByIdAsync(id);
        if (user is null)
        {
            return NotFound();
        }
        return Ok(user);
    }


    [HttpDelete("/users/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _userInterface.DeleteUserAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpPut("/users/{id}")]
    public async Task<IActionResult> Update(int id, UserRequestModel request)
    {
        var updated = await _userInterface.UpdateUserAsync(id, request);
        if (!updated)
        {
            return NotFound();
        }
        return NoContent();
    }


}

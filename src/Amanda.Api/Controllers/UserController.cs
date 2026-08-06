using Microsoft.AspNetCore.Mvc;

namespace Amanda.Api.Controllers;

[ApiController]
[Route("[controller]")]  
public class UserCotroller : ControllerBase
{

    [HttpGet(Name = "GetWeatherForecast")]
    public string Index()
    {
        return "This is my default action...";
    }
    
}

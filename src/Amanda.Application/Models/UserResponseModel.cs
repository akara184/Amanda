namespace Amanda.Application.Models;

public class UserResponseModel{
    
    public int Id { get; set; }
    
    public string Username { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
}


// Tudo menos o Password, ou seja, é mais conveniente retorna esse resultado

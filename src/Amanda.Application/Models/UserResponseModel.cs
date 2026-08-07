using System.ComponentModel.DataAnnotations;

namespace Amanda.Application.Models;

public class UserResponseModel{
    
    //    public int Id { get; set; }
    [Required]
    public string Username { get; set; } = string.Empty;
    
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    public string Password { get; set; } = string.Empty;
    
    public DateTime Date_time { get; set; }
    // ^^^ preciso ver se vai ser necessário o data
}


// Tudo menos o Password, ou seja, é mais conveniente retorna esse resultado

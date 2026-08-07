using System.ComponentModel.DataAnnotations;
namespace Amanda.Application.Models;

public class UserRequestModel
{
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

// Esse tem a senha

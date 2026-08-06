namespace Amanda.Application.Models;

public class UserResponseModel{
    
    public int Id { get; set; } 
    public string Nome { get; set; } = string.Empty;    
    public string Email { get; set; } = string.Empty;
    public DateTime CreatedTimestamp { get; set; }
    // ^^^ preciso ver se vai ser necessário o data
}


// Tudo menos o Password, ou seja, é mais conveniente retorna esse resultado

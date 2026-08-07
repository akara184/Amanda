using System.ComponentModel.DataAnnotations;
namespace Amanda.Domain.Entities;

public class User {

    public int Id { get; set; }
    [Required]
    public String Username { get; set; }

    [Required]
    [EmailAddress]
    public String Email { get; set; }

    [Required]
    public String Password { get; set; } 

    [DataType(DataType.Date)] // << preciso checar isso se vale o notation, <<< provavelmente vou tirar idk 
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)] // Nao sei se vai funcionar
    public DateTime Date_time { get; set; }
    
}

   


//     [DataType(DataType.EmailAddress)] ou [EmailAddress] =
//     https://learn.microsoft.com/en-us/archive/msdn-technet-forums/1ad08507-6dcc-44d1-ba86-2147a8fb1924

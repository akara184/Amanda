namespace Amanda.Domain.Entities;
using System.ComponentModel.DataAnnotations;


public class User {

    public int Id { get; set; }
    
    public String Nome { get; set; }


    [EmailAddress]
    public String Email { get; set; }
    
    public String Senha { get; set; } 

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime CreatedTimestamp { get; set; }
    
}

   


//     [DataType(DataType.EmailAddress)] ou [EmailAddress] =
//     https://learn.microsoft.com/en-us/archive/msdn-technet-forums/1ad08507-6dcc-44d1-ba86-2147a8fb1924

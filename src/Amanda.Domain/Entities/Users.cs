namespace Amanda.Domain.Entities;
using System.ComponentModel.DataAnnotations;


public class User {

    public int Id { get; set; }
    
    public String Nome { get; set; }
    
    public String Email { get; set; }
    
    public String Senha { get; set; } 

     [DataType(DataType.Date)]
     [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime CreatedTimestamp { get; set; }
    
}

   

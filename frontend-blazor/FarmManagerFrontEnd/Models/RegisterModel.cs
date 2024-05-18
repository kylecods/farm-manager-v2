using System.ComponentModel.DataAnnotations;

namespace FarmManagerFrontEnd.Models;

public record RegisterModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
        
    [Required]
    public string Password { get; set; }
    
    [Required]
    public string ConfirmPassword { get; set; }
}
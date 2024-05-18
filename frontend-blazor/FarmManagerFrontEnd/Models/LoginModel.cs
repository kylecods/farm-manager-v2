using System.ComponentModel.DataAnnotations;

namespace FarmManagerFrontEnd.Models;

public record LoginModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
        
    [Required]
    public string Password { get; set; }
        
    public bool RememberMe { get; set; }
}
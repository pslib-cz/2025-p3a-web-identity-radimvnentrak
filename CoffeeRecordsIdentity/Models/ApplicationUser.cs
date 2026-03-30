using System.ComponentModel.DataAnnotations;

namespace CoffeeRecordsIdentity.Models;

public class ApplicationUser
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
}

namespace pahsolutionsportfolio.Models;

using System.ComponentModel.DataAnnotations;

public class ContactAdminViewModel
{
    [Required]
    public string Password { get; set; } = string.Empty;

    public bool Authenticated { get; set; } = false;    
    public List<ContactViewModel> ListData { get; set; } = [];
}

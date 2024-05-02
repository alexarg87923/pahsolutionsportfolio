namespace pahsolutionsportfolio.Models;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ContactViewModel
{
    public int ID { get; set; }

    [Required]
    public string SelectedField { get; set; } = string.Empty;

    [Required]
    public string Name { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    [Required]
    public bool IsNDARequired  { get; set; } = false;



    public IEnumerable<SelectListItem> Fields { get; } =
    [
        new SelectListItem { Text = "Healthcare", Value = "Healthcare" },
        new SelectListItem { Text = "Financial Services", Value = "Financial Services" },
        new SelectListItem { Text = "Logistics & Supply Chain", Value = "Logistics & Supply Chain" },
        new SelectListItem { Text = "Personal Project", Value = "Personal Project" },
        new SelectListItem { Text = "Other", Value = "Other" }
    ];
    public override string ToString()
    {
        return $"SelectedField: {SelectedField}, Name: {Name}, Email: {Email}, Description: {Description}, IsNDARequired: {IsNDARequired}";
    }
}

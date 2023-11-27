using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o título")]
    [MinLength(3, ErrorMessage = "O categoria deve ter pelo menos 3 caracteres")]
    [MaxLength(60, ErrorMessage = "O categoria deve no máximo 60 caracteres")]
    public string Title { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = new();
}

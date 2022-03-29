using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab3.Models;

public class Product
{
    public int ProductId { get; set; }

    [Display(Name = "Title")]
    public string? ProductName { get; set; }

    [Display(Name = "Book")]
    public string? ImageLink { get; set; }

    [Range(0, 20000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(7,2)")]
    public decimal Price { get; set; }

    public int Quantity { get; set; }
}
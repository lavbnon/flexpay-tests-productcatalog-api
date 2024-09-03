using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexpay.ProductCatalog.WebApi;

[Table("Products")]
public class Product
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CatalogId { get; set; }
}
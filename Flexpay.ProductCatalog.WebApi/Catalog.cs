using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexpay.ProductCatalog.WebApi;

[Table("Catalogs")]
public class Catalog
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Product> Products { get; set; } = new List<Product>();
    
    // TODO: do not include this property in the api output
    [NotMapped]
    public string? PrivateCatalogIdentifier { get; set; }
}
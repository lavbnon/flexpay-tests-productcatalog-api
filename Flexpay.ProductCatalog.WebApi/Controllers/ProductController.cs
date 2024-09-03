using Microsoft.AspNetCore.Mvc;

namespace Flexpay.ProductCatalog.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductCatalogDbContext _dbContext;

    public ProductsController(ProductCatalogDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbContext.Database.EnsureCreated();
    }
    
    [HttpGet("catalogs")]
    public IEnumerable<Catalog> GetCatalogs()
    {
        return _dbContext.Catalogs.ToArray();
    }

    [HttpGet("{catalogId}")]
    public IEnumerable<Product> Get(int catalogId)
    {
        return _dbContext.Products.Where(x => x.CatalogId == catalogId).ToArray();
    }
    
    [HttpGet("{catalogId}/{productId}")]
    public async Task<Product?> GetByIdAsync(int catalogId, Guid productId)
    {
        return await _dbContext.Products.FindAsync(productId);
    }
    
    [HttpPost]
    public async Task<Product> AddProductAsync(Product product)
    {
        if (product.Price <= 0)
        {
            throw new ArgumentException("Price must be greater than 0");
        }
        
        _dbContext.Products.Add(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }
}
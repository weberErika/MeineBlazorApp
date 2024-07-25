namespace MeineBlazorApp.Services;

public class ProductService
{
    private readonly List<Models.Product> _products;

    public ProductService()
    {
        _products = new List<Models.Product>
            {
                new Models.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new Models.Product { Id = 2, Name = "Product 2", Price = 20.0m },
                new Models.Product { Id = 3, Name = "Product 3", Price = 30.0m },
            };
    }

    public IEnumerable<Models.Product> GetAllProducts()
    {
        return _products;
    }

    public Models.Product GetProductById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
}
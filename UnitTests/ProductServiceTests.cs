using MeineBlazorApp.Services;
namespace UnitTests;

public class ProductServiceTests
{

    private readonly ProductService _productService;

    public ProductServiceTests()
    {
        _productService = new ProductService();
    }

    [Fact]
    public void GetAllProducts_ReturnsAllProducts()
    {
        // Act
        var products = _productService.GetAllProducts();

        // Assert
        Assert.Equal(3, products.Count());
    }

    [Theory]
    [InlineData(1, "Product 1")]
    [InlineData(2, "Product 2")]
    [InlineData(3, "Product 3")]
    public void GetProductById_ReturnsCorrectProduct(int id, string expectedName)
    {
        // Act
        var product = _productService.GetProductById(id);

        // Assert
        Assert.NotNull(product);
        Assert.Equal(expectedName, product.Name);
    }

}
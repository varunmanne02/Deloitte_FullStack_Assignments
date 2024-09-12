using WebApplication4.Models;

namespace WebApplication4.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int id);
        public void AddProduct(Product productObj);
        public string EditProduct(Product productObj);
        public string DeleteProduct(int id);
        public List<Product> GetAllProductsByCategory(string Category);
        public List<Product> OutOfStockProducts();
        public List<Product> ProductsRange(int Min, int Max);
        public List<String> GetCategories();

    }
}
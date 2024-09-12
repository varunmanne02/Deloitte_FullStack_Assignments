using WebApplication4.Models;

namespace WebApplication4.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product ProductObj);
        public string EditProduct(Product productObj);
        public string DeleteProduct(int id);
        public List<Product> GetAllProductsByCategory(string Category);
        public List<Product> OutOfStockProducts();
        public List<Product> ProductsRange(int Min, int Max);

        public List<String> GetCategories();
    }
}
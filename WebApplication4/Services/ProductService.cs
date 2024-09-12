using WebApplication4.Models;
using WebApplication4.Repositories;

namespace WebApplication4.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public void AddProduct(Product ProductObj)
        {
            _repository.AddProduct(ProductObj);
        }

        public string EditProduct(Product ProductObj)
        {
           return _repository.EditProduct(ProductObj);
        }

        public string DeleteProduct(int id)
        {
            return _repository.DeleteProduct(id);
        }

        public List<Product> GetAllProductsByCategory(string Category)
        {
            return _repository.GetAllProductsByCategory(Category);
        }

        public List<Product> OutOfStockProducts()
        {
            return _repository.OutOfStockProducts();
        }
        public List<Product> ProductsRange(int Min, int Max)
        {
            return _repository.ProductsRange(Min,Max);
        }

        public List<String> GetCategories()
        {
            return _repository.GetCategories();
        }
    }
}
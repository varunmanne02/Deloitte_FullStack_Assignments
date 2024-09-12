using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public SalesDbContext _context;
        public ProductRepository(SalesDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product ProductObj)
        {
            _context.Products.Add(ProductObj);
            _context.SaveChanges();
        }
        public string EditProduct(Product ProductObj)
        {
            _context.Products.Update(ProductObj);
            _context.SaveChanges();
            return "Product details updated succesfully";
        }

        public string DeleteProduct(int id)
        {
            Product obj = _context.Products.Find(id);

            if (obj != null)
            {
                _context.Products.Remove(obj);
                _context.SaveChanges();
                return "1";
            }
            else
            {
                return "-1";
            }
        }

        public List<Product> GetAllProductsByCategory(string Category)
        {
           List<Product> products = _context.Products.Where( x  => x.Category == Category ).ToList();
            return products;
        }

        public List<Product> OutOfStockProducts()
        {
            List<Product> products = _context.Products.Where(x => x.Quantity == 0).ToList();
            return products;
        }

        public List<Product> ProductsRange(int Min, int Max)
        {
            List<Product> products = _context.Products.Where(x => (x.UnitPrice >= Min && x.UnitPrice <= Max)).ToList();
            return products;
        }

        public List<String> GetCategories()
        {
            List<String> categories = (from  x in _context.Products
                                      select x.Category).Distinct().ToList();
            return categories;
        }
    }
}
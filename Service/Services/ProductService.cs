using Domain.Data;
using Domain.Models;
using Service.Services.Interface;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService()
        {
            _context = new AppDbContext();
        }

        public Product[] GetAll()
        {
            return _context.Products();
        }

        public Product[] GetAllByCategoryId(int id)
        {
           return _context.Products().Where(m =>m.Category.Id == id).ToArray();
        }

        public Product[] GetAllByCategoryName(string categoryName)
        {
            return _context.Products().Where(m => m.Category.Name == categoryName). ToArray();
        }

        public decimal GetAveragePrice()
        {
            var products = _context.Products();
            int productCount = products.Length;
            decimal sumOfPrice= products.Sum(m => m.Price);
            return sumOfPrice/productCount;
        }

        public int GetCount()
        {
            var products = _context.Products();
            return products.Length;
        }

        public Product[] OrderByDate()
        {
            return _context.Products().OrderByDescending(m => m.CreateDate).ToArray();
        }

        public Product[] Search(string searchText)
        {
            return _context.Products().Where(m =>m.Name.Trim().ToLower() .Contains(searchText.ToLower())).ToArray();
        }
    }
}

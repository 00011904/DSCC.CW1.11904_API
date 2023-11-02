using DSCC.CW1._11904_API.DBContext;
using DSCC.CW1._11904_API.Model;
using Microsoft.EntityFrameworkCore;

namespace DSCC.CW1._11904_API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;
        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            Save();
        }
        public Product GetProductById(int productId)
        {
            var prod = _dbContext.Products.Find(productId);
            return prod;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }
        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
      
    }
}

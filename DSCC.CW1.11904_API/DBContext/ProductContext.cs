using DSCC.CW1._11904_API.Model;
using Microsoft.EntityFrameworkCore;

namespace DSCC.CW1._11904_API.DBContext
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=database-1.c2uh0ejdy9ez.eu-north-1.rds.amazonaws.com;Port=5432;Database=Product;Username=postgres;Password=00011904");
    }
}

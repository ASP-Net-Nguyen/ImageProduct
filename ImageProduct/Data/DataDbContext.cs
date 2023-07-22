using ImageProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageProduct.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> productModels { get; set; }
        public DbSet<ProductImage> imageModels { get; set; }
    }
}

using API_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Shop.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

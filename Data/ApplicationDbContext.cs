using Microsoft.EntityFrameworkCore;

namespace eCommerce_WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        //Add your tables, See below
       // public DbSet<Review> Reviews { get; set; }
    }
}

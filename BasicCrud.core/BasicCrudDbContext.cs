using BasicCrud.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCrud.core
{
    public class BasicCrudDbContext : DbContext
    {

        public BasicCrudDbContext(DbContextOptions<BasicCrudDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
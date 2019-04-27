using Microsoft.EntityFrameworkCore;
using Models;

namespace DatabaseContext.DbContext
{
    public class CustomerDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=(local);database=CustomerDb; Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

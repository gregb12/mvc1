using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class AZURE_SQL_CONNECTIONSTRING:DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }
        public DbSet<Customer> Customer { get; set; } = null!;
    }
}

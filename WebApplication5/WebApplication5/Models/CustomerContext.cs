using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class AZURE_SQL_CONNECTIONSTRING:DbContext
    {

        public CAZURE_SQL_CONNECTIONSTRING(DbContextOptions<AZURE_SQL_CONNECTIONSTRING> options) : base(options) { }
        public DbSet<Customer> Customer { get; set; } = null!;
    }
}

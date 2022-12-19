using EmplohyeeAppMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace EmplohyeeAppMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}

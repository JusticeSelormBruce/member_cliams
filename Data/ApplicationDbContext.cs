using Cliams.Models;
using Microsoft.EntityFrameworkCore;


namespace Cliams.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
           
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Claim> Cliams { get; set; }
    }
}

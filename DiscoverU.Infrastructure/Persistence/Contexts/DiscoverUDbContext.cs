using DiscoverU.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiscoverU.Infrastructure.Persistence.Contexts
{
    public class DiscoverUDbContext:DbContext
    {
       public DbSet<AdminLogin> AdminLogins { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Survey> Surveys { get; set;}

        public DiscoverUDbContext(DbContextOptions<DiscoverUDbContext> options) : base(options)
        {
            
        }
    }
}

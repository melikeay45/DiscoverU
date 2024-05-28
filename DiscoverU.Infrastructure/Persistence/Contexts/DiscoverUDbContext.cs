using DiscoverU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}

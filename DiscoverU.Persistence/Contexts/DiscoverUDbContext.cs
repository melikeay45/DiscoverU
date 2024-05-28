using DiscoverU.Domain.Entities;
using System.Collections.Generic;

namespace DiscoverU.Persistence.Contexts
{
    public class DiscoverUDbContext
    {
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}

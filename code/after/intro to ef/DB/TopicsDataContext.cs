using System.Data.Entity;

namespace intro_to_ef.DB
{
    public class TopicsDataContext : DbContext
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Tutorial> Tutorials { get; set; }
    }
}
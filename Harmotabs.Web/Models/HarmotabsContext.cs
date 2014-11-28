using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Harmotabs.Web.Models
{
    public class HarmotabsContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Tablature> Tablatures { get; set; }
        public DbSet<User> Users { get; set; }

        public HarmotabsContext() : base("HarmotabsContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
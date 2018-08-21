using AspCoreApi.DataContext.EntityConfigurations;
using AspCoreApi.Models.Angular;
using Microsoft.EntityFrameworkCore;

namespace AspCoreApi.DataContext
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }
    }
}
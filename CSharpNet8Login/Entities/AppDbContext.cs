using Microsoft.EntityFrameworkCore;

namespace CSharpNet8Login.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserAccount>()
            //    .HasIndex(u => u.Email)
            //    .IsUnique();
            //modelBuilder.Entity<UserAccount>()
            //    .HasIndex(u => u.Username)
            //    .IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}

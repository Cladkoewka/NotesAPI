using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    
    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Note>().HasKey(x => x.Id);
        modelBuilder.Entity<Note>().Property(x => x.Text).HasMaxLength(140);
        base.OnModelCreating(modelBuilder);
    }
}
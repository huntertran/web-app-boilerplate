using Microsoft.EntityFrameworkCore;
using Users;

public class AppContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public string DbPath { get; }

    public AppContext()
    {
        // Save to bin\debug\netX folder
        var folder = AppDomain.CurrentDomain.BaseDirectory;
        DbPath = Path.Combine(folder, "web-app-boilerplate.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
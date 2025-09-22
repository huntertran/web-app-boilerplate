using Microsoft.EntityFrameworkCore;

public class UserContext : DbContext
{
    public string DbPath { get; }
    public UserContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "user.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlite($"Data Source={DbPath}");
}
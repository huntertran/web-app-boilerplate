using Microsoft.EntityFrameworkCore;

namespace Users
{
    public class UserContext : DbContext
    {
        public string DbPath { get; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "users.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
        public DbSet<User> UsersItem { get; set; } = null;
    }
}
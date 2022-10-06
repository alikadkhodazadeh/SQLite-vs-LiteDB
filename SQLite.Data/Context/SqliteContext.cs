namespace SQLite.Data;

public class SqliteContext : DbContext
{
    const string connectionString = "Data Source=People.sqlite";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; } = null!;
}

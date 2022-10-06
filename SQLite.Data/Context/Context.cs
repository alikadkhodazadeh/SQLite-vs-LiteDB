namespace SQLite.Data;

public class Context : DbContext
{
    const string connectionString = "Data Source=People.sqlite";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString, options =>
        {
            options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        });
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; } = null!;
}

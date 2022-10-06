namespace SQLite.Data;

public class SqliteRepositoryFactory
{
    public ISqliteRepository CreateRepository()
    {
        SqliteContext db = new SqliteContextFactory().CreateDbContext(null!);
        return new SqliteRepository(db);
    }
}
namespace SQLite.Data;

public class SqliteRepositoryFactory
{
    public ISqliteRepository CreateRepository()
    {
        Context db = new ContextFactory().CreateDbContext(null!);
        return new SqliteRepository(db);
    }
}
using Microsoft.EntityFrameworkCore.Design;

namespace SQLite.Data;

public sealed class SqliteContextFactory : IDesignTimeDbContextFactory<SqliteContext>
{
    public SqliteContext CreateDbContext(string[] args)
    {
        return new();
    }
}
using Microsoft.EntityFrameworkCore.Design;

namespace SQLite.Data;

public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        return new();
    }
}
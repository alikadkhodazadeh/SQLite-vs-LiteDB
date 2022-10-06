[InProcess]
[MemoryDiagnoser]
public class DatabaseQueries
{
    [Benchmark]
    public void Get_All_Record_From_SQLite()
    {
        using var repository = new SqliteRepositoryFactory().CreateRepository();
        var count = repository.Get();
    }

    // LiteDB (NoSQL databases) should be static (Singleton)
    static ILiteDbRepository liteDbRepository = new LiteDbRepositoryFactory().CreateRepository();

    [Benchmark]
    public void Get_All_Record_From_LiteDB()
    {
        //var repository = new LiteDbRepositoryFactory().CreateRepository();
        var count = liteDbRepository.Get();
    }
}
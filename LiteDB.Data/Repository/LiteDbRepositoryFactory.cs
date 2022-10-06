namespace LiteDB.Data;

public class LiteDbRepositoryFactory
{
    public ILiteDbRepository CreateRepository()
    {
        return new LiteDbRepository();
    }
}
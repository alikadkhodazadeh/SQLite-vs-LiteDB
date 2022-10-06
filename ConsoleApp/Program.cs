internal class Program
{
    static void Main()
    {
        var repo = new SqliteRepositoryFactory().CreateRepository();
        Console.WriteLine(JsonSerializer.Serialize(repo.Get()));
    }
}
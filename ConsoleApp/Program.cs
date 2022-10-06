internal class Program
{
    static void Main()
    {
        BenchmarkRunner.Run(typeof(DatabaseQueries).Assembly);
    }
}

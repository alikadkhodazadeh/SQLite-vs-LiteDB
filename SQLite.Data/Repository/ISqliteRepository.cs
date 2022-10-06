namespace SQLite.Data;

public interface ISqliteRepository : IDisposable
{
    IReadOnlyList<User> Get();
    User? GetById(int id);
    void Add(User user);
    void Add(IEnumerable<User> users);
    void Save();
}
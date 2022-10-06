namespace LiteDB.Data;

public class LiteDbRepository : ILiteDbRepository
{
    private readonly LiteDatabase _db;
    private readonly ILiteCollection<User> _users;
    const string dbName = "People-LiteDb.db";

    public LiteDbRepository()
    {
        _db = new(dbName);
        _users = _db.GetCollection<User>();
    }

    public void Add(User user) => _users.Insert(user);

    public void Add(IEnumerable<User> users) => _users.InsertBulk(users);

    public void Dispose() => _db.Dispose();

    public IReadOnlyList<User> Get() => _users.FindAll().ToList().AsReadOnly();

    public User? GetById(int id) => _users.FindById(id);
}

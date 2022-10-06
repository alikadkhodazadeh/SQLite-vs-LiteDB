namespace SQLite.Data;

public class SqliteRepository : ISqliteRepository
{
    private readonly SqliteContext _context;

    public SqliteRepository(SqliteContext context) => _context = context;

    public void Add(User user) => _context.Users.Add(user);
    public void Add(IEnumerable<User> users) => _context.Users.AddRange(users);
    public IReadOnlyList<User> Get() => _context.Users.AsNoTracking().ToList().AsReadOnly();
    public User? GetById(int id) => _context.Users.AsNoTracking().FirstOrDefault(_ => _.Number == id);
    public User? Find(int id) => _context.Users.Find(id);
    public void Save() => _context.SaveChanges();
    public void Dispose() => _context.Dispose();
}

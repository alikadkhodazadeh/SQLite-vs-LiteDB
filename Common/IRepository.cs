public interface IRepository : IDisposable
{
    IReadOnlyList<User> Get();
    User? GetById(int id);
    void Add(User user);
    void Add(IEnumerable<User> users);
}
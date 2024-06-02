using LiteDB;

namespace BookManager.Data.Services
{
    public class DbConnectionService : IDisposable
    {
        private readonly LiteDatabase _db;

        public DbConnectionService(string connectionString)
        {
            _db = new LiteDatabase(connectionString);
        }

        public ILiteCollection<T> GetCollection<T>(string collectionName) => _db.GetCollection<T>(collectionName);

        public void Dispose()
        {
            _db?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

using BookManager.Data.Models;
using BookManager.Data.Services;
using LiteDB;

namespace BookManager.Data.Context
{
    public abstract class BaseContext<T> where T : BaseModel
    {
        private readonly DbConnectionService _db;
        private readonly string _collection;

        public BaseContext(DbConnectionService db, string collection)
        {
            _db = db;
            _collection = collection;
        }

        public ILiteCollection<T> GetCollection() => _db.GetCollection<T>(_collection);

        public void Add(T entity) => GetCollection().Insert(entity);
        public void Save(T entity) => GetCollection().Update(entity);
        public void Delete(T entity) => GetCollection().Delete(entity.Id);
        public T Get(Guid id)  => GetCollection().FindOne(x => x.Id == id);

        public IEnumerable<T> GetAll() => GetCollection().FindAll();
        public int GetCollectionSize() => GetCollection().Count();
    }
}

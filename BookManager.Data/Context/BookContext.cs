using BookManager.Data.Models;
using BookManager.Data.Services;

namespace BookManager.Data.Context
{
    public class BookContext : BaseContext<Book>
    {
        private const string Collection = "Books";

        public BookContext(DbConnectionService db) : base(db, Collection) { }

        public Book[] GetBooksForAuthor(Guid id) => GetCollection().Query().Where(x => x.Author.Id == id).ToArray();
    }
}

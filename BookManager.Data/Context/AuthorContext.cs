using BookManager.Data.Models;
using BookManager.Data.Services;

namespace BookManager.Data.Context
{
    public class AuthorContext : BaseContext<Author>
    {
        private const string Collection = "Authors";

        public AuthorContext(DbConnectionService db) : base(db, Collection) { }
    }
}

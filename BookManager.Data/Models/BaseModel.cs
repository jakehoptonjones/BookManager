using LiteDB;

namespace BookManager.Data.Models
{
    public class BaseModel
    {
        [BsonCtor]
        public BaseModel()
        {
            Id = Guid.NewGuid();
        }

        [BsonId]
        public Guid Id { get; set; }
    }
}

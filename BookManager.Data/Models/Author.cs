namespace BookManager.Data.Models
{
    public class Author : BaseModel
    {
        public Author() : base() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name() => $"{FirstName} {LastName}";
    }
}

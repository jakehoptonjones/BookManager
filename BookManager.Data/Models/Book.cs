namespace BookManager.Data.Models
{
    public class Book : BaseModel
    {
        public Book() : base()
        {
            Reviews = new();
        }

        public string Title { get; set; }
        public string Blurb { get; set; }
        public int PageCount { get; set; }
        public ModelReference Author { get; set; }
        public DateTime DatePublished { get; set; }
        public List<Review> Reviews { get; set; }

        public double GetAverageRating() => Reviews.Any() ? Reviews.Sum(r => r.Rating) / (double)Reviews.Count : 0;
        public int GetRoundAverageRating() => (int)Math.Round(GetAverageRating());
    }
}

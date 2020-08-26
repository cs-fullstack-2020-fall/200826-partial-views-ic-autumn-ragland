namespace MovieListing.Models
{
    public class Movie{
        public string title;
        public string description;
        public int rating;
        public Movie(string title, string description, int rating)
        {
            this.title = title;
            this.description = description;
            this.rating = rating;
        }
    }
}
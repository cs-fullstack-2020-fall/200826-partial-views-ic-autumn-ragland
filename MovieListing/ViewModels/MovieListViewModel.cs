using System.Collections.Generic;
using MovieListing.Models;

namespace MovieListing.ViewModels
{
    public class MovieListViewModel
    {
        public List<Movie> movieList = new List<Movie>();
        public MovieListViewModel()
        {
            movieList.Add(new Movie("Movie One", "An okay movie", 3));
            movieList.Add(new Movie("Movie Two", "A great movie", 5));
            movieList.Add(new Movie("Movie Three", "A bad movie", 3));
        }
    }
}
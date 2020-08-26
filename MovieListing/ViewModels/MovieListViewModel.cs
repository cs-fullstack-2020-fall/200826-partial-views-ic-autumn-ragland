using System.Collections.Generic;
using MovieListing.Models;

namespace MovieListing.ViewModels
{
    public class MovieListViewModel
    {
        public List<Movie> movieList = new List<Movie>();
        public MovieListViewModel()
        {
            movieList.Add(new Movie("Arrival", "For those who are disappointed that the close encounter Amy Adams has with aliens in Arrival is about communication instead of global annihilation, I can offer no comfort. Except to say that the contemplative tone taken by director Denis Villeneuve and the full commitment Adams brings to a role of ever-surprising layers result in a movie that stays with you long after you leave the multiplex.", 5));
            movieList.Add(new Movie("Sully", "Clint Eastwood's brand of classic, no-bullshit filmmaking finds perfect form as a beautifully understated Tom Hanks plays Capt. Chesley Sullenberger, the hero pilot who ditched his disabled plane on the Hudson River and saved the lives of all on board. Job well done. That goes for the man and the movie.", 1));
            movieList.Add(new Movie("Moonlight", "Three wonderful actors (Alex Hibbert, Ashton Sanders and Trevante Rhodes) play the same boy at different stages of growing up black, gay and alienated in the Miami projects. Director Barry Jenkins handles every aspect of filmmaking, from dialogue to visuals, like the young master he is.", 10));
            movieList.Add(new Movie("La la Land", "Emma Stone and Ryan Gosling hit career peaks as lovers who try to make their creative dreams come true on the mean, art-fearing streets of the New Hollywood. La La Land swings for the fences. Chazelle puts his heart right out there where hipsters can mock him as tragically untrendy.", 2));
            movieList.Add(new Movie("Fences", "What a triumph for Denzel Washington, who directs and stars in the film version of the stage success by the late, great August Wilson. Washington is monumental as a former Negro League baseball player now collecting garbage in Pittsburgh and roaring against anything that challenges his authority as husband and father. Viola Davis is Oscar material as his wife.", 7));
        }
    }
}
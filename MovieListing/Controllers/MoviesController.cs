using Microsoft.AspNetCore.Mvc;
using MovieListing.ViewModels;
using System.Collections.Generic;
using System.Linq;
using MovieListing.Models;

namespace MovieListing.Controllers{
    public class Movies : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public MovieListViewModel movieList = new MovieListViewModel();
        public IActionResult ViewAll()
        {
            return View(movieList);
        }
         public IActionResult ViewPositive()
         {
             return View(movieList);
         }
         public IActionResult ViewNegative()
         {
             return View(movieList);
         }
    }
}

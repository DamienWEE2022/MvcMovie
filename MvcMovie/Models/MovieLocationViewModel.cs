using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieLocationViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Locations { get; set; }
        public string? MovieLocation { get; set; }
        public string? SearchString { get; set; }
    }
}

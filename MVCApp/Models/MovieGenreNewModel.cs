﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCApp.Models
{
    public class MovieGenreNewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set;}
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}

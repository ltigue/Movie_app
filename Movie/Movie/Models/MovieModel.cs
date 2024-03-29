﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieProg.Models
{
    public class MovieModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
    public class MovieDBContext : DbContext
    {
        public DbSet<MovieProg> Movies { get; set; }
    }
}
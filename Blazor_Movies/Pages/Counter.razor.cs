﻿using Blazor_Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Movies.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }

        private List<Movie> movies;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3000);

            movies = new List<Movie>()
    {
            new Movie(){Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2)},
            new Movie(){Title = "Avengers", ReleaseDate = new DateTime(2011, 6, 4)},
            new Movie(){Title = "He-Man", ReleaseDate = new DateTime(1989, 2, 4)},
        };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            MovieList movies = new MovieList();
            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine($"There are {movies.Movies.Count} movies in this list.");
            while (goOn)
            {
                movies.DisplayCategory();
                goOn = movies.GoAgain();
            }
            List<Movie> check = movies.Movies.OrderBy(x => x.Title).ToList();
            for (int i =0; i < movies.Movies.Count; i++)
            {
                Console.WriteLine(movies.Movies[i].Title);
            }
            for (int i = 0; i < check.Count; i++)
            {
                Console.WriteLine(check[i].Title);
            }

            Console.WriteLine("Goodbye!");
        }
    }
}

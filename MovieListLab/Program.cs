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
            

            Console.WriteLine("Goodbye!");
        }
    }
}

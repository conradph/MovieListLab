using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MovieListLab
{
    class MovieList
    {
        public List<Movie> Movies = new List<Movie>();

        public List<string> Categories = new List<string>();

        public MovieList()
        {
            //Initialize list with movies
            Movies.Add(new Movie("Shawshank Redemption", "Drama"));
            Movies.Add(new Movie("The Godfather", "Drama"));
            Movies.Add(new Movie("Pulp Fiction", "Drama"));
            Movies.Add(new Movie("The Shining", "Horror"));
            Movies.Add(new Movie("The Ring", "Horror"));
            Movies.Add(new Movie("The Exorcist", "Horror"));
            Movies.Add(new Movie("The Matrix", "SciFi"));
            Movies.Add(new Movie("Interstellar", "SciFi"));
            Movies.Add(new Movie("The Martian", "SciFi"));
            Movies.Add(new Movie("Toy Story", "Animated"));
            Movies.Add(new Movie("Toy Story 2", "Animated"));
            Movies.Add(new Movie("Toy Story 3", "Animated"));
            Movies.Add(new Movie("Finding Nemo", "Animated"));

            for (int i = 0; i < Movies.Count; i++)
            {
                if (Categories.IndexOf(Movies[i].Category) == -1)
                {
                    Categories.Add(Movies[i].Category);
                }
            }
            Movies = Movies.OrderBy(x => x.Title).ToList(); //sets the list to be in alphabetical order by movie title
            
        }
        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine().Trim();
        }
        public void DisplayCategory()
        {
            DisplayCategories();
            string category;
            while (true)
            {
                try
                {
                    category = GetInput("What category are you interested in?");
                    int option = int.Parse(category);
                    category = Categories[option];
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer. Try Again.");
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Please enter an integer between 0 and {Categories.Count-1}.");
                    continue;
                }
            }
            bool found = false;
            for (int i = 0; i < Movies.Count; i++)
            {
                if (category.ToLower() == Movies[i].Category.ToLower())
                {
                    found = true;
                    Console.WriteLine($"{Movies[i].Title}");
                }
                
            }
            if (!found)
            {
                Console.WriteLine($"No movies in {category} were found.");
            }
        }
        public bool GetYesOrNo(string prompt)
        {
            bool invalidResponse = true;
            bool output = true;
            while (invalidResponse)
            {
                string response = GetInput(prompt + "(y/n)").ToLower();
                if (response == "y")
                {
                    output = true;
                    invalidResponse = false;
                }
                else if (response == "n")
                {
                    output = false;
                    invalidResponse = false;
                }
                else
                {
                    Console.WriteLine("Please input only a y or n and try again.");
                    invalidResponse = true;
                }
            }
            return output;
        }
        public bool GoAgain()
        {
            return GetYesOrNo("Continue?");
        }
        public void DisplayCategories()
        {
            
            for (int i = 0; i < Categories.Count; i++)
            {
                Console.WriteLine($"{i}: {Categories[i]}");
            }
        }
    }
}

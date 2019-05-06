using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Sort();

            Movie movie1 = new Movie("The Lion King", "Animated");
            movies.Add(movie1);

            Movie movie2 = new Movie("The Godfather", "Drama");
            movies.Add(movie2);

            Movie movie3 = new Movie("The Conjuring", "Horror");
            movies.Add(movie3);

            Movie movie4 = new Movie("The Matrix", "SciFi");
            movies.Add(movie4);

            Movie movie5 = new Movie("Avengers: End Game", "SciFi");
            movies.Add(movie5);

            Movie movie6 = new Movie("The Dark Knight", "SciFi");
            movies.Add(movie6);

            Movie movie7 = new Movie("The Jungle Book", "Animated");
            movies.Add(movie7);

            Movie movie8 = new Movie("Avatar", "Animated");
            movies.Add(movie8);

            Movie movie9 = new Movie("Good Fellas", "Drama");
            movies.Add(movie9);

            Movie movie10 = new Movie("Scarface", "Drama");
            movies.Add(movie10);

            Console.WriteLine("Welcome to the Movie List Application!");

            Movie.Menu(movies);



        }

    }
}


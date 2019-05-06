using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string title;
        private string category;

        //public string Title
        //{
        //    set
        //    {
        //        title = value;
        //    }
        //    get
        //    {
        //        return title;
        //    }
        //}

        //public string Category
        //{
        //    set
        //    {
        //        category = value;
        //    }
        //    get
        //    {
        //        return category;
        //    }
        //}

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        public static void Menu(List<Movie> movies)
        {

            string response = "y";
            while (response == "y")
            {
               
                Console.WriteLine("\nThere are 10 movies in this list" + "\nWhat category are you interested in?");

                switch (ReadUserInput())
                {
                    case "1":
                        {
                            PrintMovies(movies, "Animated");
                            break;
                        }

                    case "2":
                        {
                            PrintMovies(movies, "Drama");
                            break;
                        }

                    case "3":
                        {
                            PrintMovies(movies, "Horror");
                            break;
                        }

                    case "4":
                        {
                            PrintMovies(movies, "SciFi");
                            break;
                        }
                    case "5":
                        response = "n";
                        Console.WriteLine("\nGood bye!");

                        break;

                    default: break;
                }
                if (response != "y")
                {
                    response = "n";
                }
                else
                {
                    
                    Console.WriteLine("Would you like to continue: (y or n)");
                    response = Console.ReadLine();
                }

            }
        }
        public static string ReadUserInput()
        {
            string userInput;
            bool isUserInputValid = false;


            do
            {
                Console.WriteLine("1.  Animated");
                Console.WriteLine("2.  Drama");
                Console.WriteLine("3.  Horror");
                Console.WriteLine("4.  SciFi");
                Console.WriteLine("5.  Quit");
                userInput = Console.ReadLine();
                userInput = userInput.Trim();
                // if its not anything but 1-5 isUserInputValid will be false.
                switch (userInput)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        isUserInputValid = true;
                        break;
                    default:
                        isUserInputValid = false;
                        break;
                }
                if (!isUserInputValid)
                {
                    Console.Clear();
                    Console.WriteLine("That's not valid input. Please input 1-5");
                }
            }
            while (!isUserInputValid);

            return userInput;

        }
        public static void PrintMovies(List<Movie> movies, string _category)
        {
            foreach (Movie film in movies)
            {
                if (film.category == _category)
                {
                    Console.WriteLine(film.title);  
                }
            }
            Console.WriteLine("--------------------");
        }
    }













}


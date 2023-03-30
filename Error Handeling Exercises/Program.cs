using System.ComponentModel.Design;

namespace Error_Handeling_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1");
            /*
            ● Make a class Movie. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them
            ● Rating should be a number from 1 to 5. Throw exception if its more or less ( you should also handle other exceptions )
            ● Set the TicketPrice to be 5 * Rating when creating a new object
            ● Genre should be an enum with Comedy, Horror, Action, Drama and SciFi
            ● Make a class Cinema. Cinema must have: Name, Halls , ListOfMovies
            ● Cinema should have method MoviePlaying that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Title”
            ● We will provide 10 movies per cinema to put in the cinema movies list
            */

            Movie one = new Movie("The Shawshank Redemption (1994)", GenreEnum.Drama, 5, 5 * 5);
            Movie two = new Movie("The Godfather (1972)", GenreEnum.Action, 5, 5 * 5);
            Movie three = new Movie("The Dark Knight (2008", GenreEnum.Action, 4, 5 * 4);
            Movie four = new Movie("Schindler's List (1993)", GenreEnum.Drama, 5, 5 * 5);
            Movie five = new Movie("The Lord of the Rings: The Return of the King (2003)", GenreEnum.SciFi, 4, 5 * 4);
            Movie six = new Movie("The Shining", GenreEnum.Horror, 3, 5 * 3);
            Movie seven = new Movie("Alien", GenreEnum.Horror, 6, 5 * 6);
            Movie eight = new Movie("Everything Everywhere All at Once", GenreEnum.Comedy, 2, 5 * 2);
            Movie nine = new Movie("Ace Ventura: Pet Detective", GenreEnum.Comedy, 3, 5 * 3);
            Movie ten = new Movie("Star Gate New-Gen", GenreEnum.SciFi, 2, 5 * 2);

            List<Movie> movieList = new List<Movie>()
            {
                    one,two,three,four,five,six,seven,eight,nine,ten
            };

            Cinema mkdCinema = new Cinema("cineplexx", 7, movieList);
            Cinema srbCinema = new Cinema("milenium", 5, movieList);
            Cinema bgCinema = new Cinema("mania", 11, movieList);


            mkdCinema.MoviePlaying(one);

            // Exercise 2
            Console.WriteLine("Exercise 2");
            /*
            ● Make a user interface that will choose a cinema.
            ● After that the user should chose if he likes to see all movies or by genre
            ● All movies - show all movies and give option to choose a movie ( the movie Playing method should be called )
            ● By genre - the user should input his favorite genre and a list of movie
            from that genre from the cinema should be displayed and give an option to choose one
            ● If the user enters a wrong input throw an exception
            ● Handle all exceptions with Try/Catch
            */

            Console.WriteLine("Hello, what Cinema would you prefer? \n 1. Cineplexx - type 1 \n 2. Milenium - type 2 \n 3. Mania - type 3");
            string cinemaChoise = Console.ReadLine();

            if (cinemaChoise == "1")
            {
                Console.WriteLine("Hello to Cineplex platform. \n How would you like your movies to be order by: \n All movies - type 4 \n By genre - type 5");
                string orderByChoise = Console.ReadLine();

                if (orderByChoise == "4")
                {
                    Console.Write("Choose a movie: \n");

                    int counter = 0;
                    foreach (Movie m in mkdCinema.ListOfMovies)
                    {
                        Console.WriteLine($"{m.Title} - type {counter += 1}");
                    }
                    string movieChoise = Console.ReadLine();

                    switch (movieChoise)
                    {
                        case "1":
                            mkdCinema.MoviePlaying(one);
                            break;
                        case "2":
                            mkdCinema.MoviePlaying(two);
                            break;
                        case "3":
                            mkdCinema.MoviePlaying(three);
                            break;
                        case "4":
                            mkdCinema.MoviePlaying(four);
                            break;
                        case "5":
                            mkdCinema.MoviePlaying(five);
                            break;
                        case "6":
                            mkdCinema.MoviePlaying(six);
                            break;
                        case "7":
                            mkdCinema.MoviePlaying(seven);
                            break;
                        case "8":
                            mkdCinema.MoviePlaying(eight);
                            break;
                        case "9":
                            mkdCinema.MoviePlaying(nine);
                            break;
                        case "10":
                            mkdCinema.MoviePlaying(ten);
                            break;
                    }

                }
                else if (orderByChoise == "5")
                {
                    Console.WriteLine("Chose your favourite genre: \n");
                    // didnt find a way to iterate Enum withour errors so little hardcode :(
                    Console.WriteLine($"({GenreEnum.Action} - type 1 \n {GenreEnum.Comedy} - type 2 \n {GenreEnum.SciFi} - type 3 \n {GenreEnum.Drama} - type 4 \n {GenreEnum.Horror} - typr 5");
                    string movieChoise = Console.ReadLine();

                    int counter = 0;
                    switch (movieChoise)
                    {
                        case "1":
                            foreach(Movie m in mkdCinema.ListOfMovies)
                            {
                                if(m.Genre == GenreEnum.Action)
                                {
                                    Console.WriteLine($"{m.Title} - type {counter += 1}");
                                }
                            }
                            string movieFinalChoise = Console.ReadLine();
                            if(movieFinalChoise == "1")
                            {
                                mkdCinema.MoviePlaying(two);
                            }
                            else if(movieFinalChoise == "2")
                            {
                                mkdCinema.MoviePlaying(three);
                            }
                            break;
                        case "2":
                            foreach (Movie m in mkdCinema.ListOfMovies)
                            {
                                if (m.Genre == GenreEnum.Comedy)
                                {
                                    Console.WriteLine($"{m.Title} - type {counter += 1}");
                                }
                            }
                            string movieFinalChoise2 = Console.ReadLine();
                            if(movieFinalChoise2 == "1")
                            {
                                mkdCinema.MoviePlaying(eight);
                            }
                            else if(movieFinalChoise2 == "2")
                            {
                                mkdCinema.MoviePlaying(nine);
                            }
                            break;
                        case "3":
                            foreach (Movie m in mkdCinema.ListOfMovies)
                            {
                                if (m.Genre == GenreEnum.SciFi)
                                {
                                    Console.WriteLine($"{m.Title} - type {counter += 1}");
                                }
                            }
                            string movieFinalChoise3 = Console.ReadLine();
                            if(movieFinalChoise3 == "1")
                            {
                                mkdCinema.MoviePlaying(five);
                            }
                            else if(movieFinalChoise3 == "2")
                            {
                                mkdCinema.MoviePlaying(ten);
                            }
                            break;
                        case "4":
                            foreach (Movie m in mkdCinema.ListOfMovies)
                            {
                                if (m.Genre == GenreEnum.Drama)
                                {
                                    Console.WriteLine($"{m.Title} - type {counter += 1}");
                                }
                            }
                            string movieFinalChoise4 = Console.ReadLine();
                            if(movieFinalChoise4 == "1")
                            {
                                mkdCinema.MoviePlaying(one);
                            }
                            else if(movieFinalChoise4 == "2")
                            {
                                mkdCinema.MoviePlaying(four);
                            }
                            break;
                        case "5":
                            foreach (Movie m in mkdCinema.ListOfMovies)
                            {
                                if (m.Genre == GenreEnum.Horror)
                                {
                                    Console.WriteLine($"{m.Title} - type {counter += 1}");
                                }
                            }
                            string movieFinalChoise5 = Console.ReadLine();
                            if(movieFinalChoise5 == "1")
                            {
                                mkdCinema.MoviePlaying(six);
                            }
                            else if(movieFinalChoise5 == "2")
                            {
                                mkdCinema.MoviePlaying(seven);
                            }
                            break;
                    }
                }

            }

        }
    }
}
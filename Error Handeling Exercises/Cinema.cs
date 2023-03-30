namespace Error_Handeling_Exercises
{
    public class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }
        public Cinema(string name,int halls,List<Movie> listOfMovies)
        {
            Name = name;
            Halls = halls;
            ListOfMovies = listOfMovies;
        }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($" Waching {movie.Title}");
        }


    }
}

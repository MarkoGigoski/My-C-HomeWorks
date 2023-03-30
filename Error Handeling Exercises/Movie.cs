namespace Error_Handeling_Exercises
{
    public class Movie
    {
        public string Title { get; set; }
        public GenreEnum Genre { get; set; }
        public int Raiting { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, GenreEnum genre, int raiting, int ticketPrice)
        {
            Title = title;
            Genre = genre;
            Raiting = raiting;
            TicketPrice = ticketPrice;
        }
    }
}

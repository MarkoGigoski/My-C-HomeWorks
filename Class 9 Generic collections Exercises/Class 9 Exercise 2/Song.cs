namespace Class_9_Exercise_2
{
    public class Song
    {
        public string Title { get; set; }
        public decimal Lenght { get; set; }
        public EnumGenre Genre { get; set; }


        public Song(string title, decimal lenght, EnumGenre genre)
        {
            Title = title;
            Lenght = lenght;
            Genre = genre;
        }
    }
}

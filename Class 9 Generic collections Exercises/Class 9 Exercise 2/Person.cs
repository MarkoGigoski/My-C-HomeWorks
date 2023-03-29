namespace Class_9_Exercise_2
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public EnumGenre FavouriteMusicType { get; set; }
        public List<Song> FavouriteSong { get; set; }
        public Person(int id, string firstName, string lastName,int age, EnumGenre favouriteMusicType,List<Song> favouriteSong)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteMusicType = favouriteMusicType;
            FavouriteSong = favouriteSong;
        }

        public void GetFavSongs(List<Song> i)
        {
            if(i.Count != 0)
            {
                foreach (Song s in FavouriteSong)
                {
                    Console.WriteLine(s.Title);
                }
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} hates music");
            }
            
        }

        

     


    }
}

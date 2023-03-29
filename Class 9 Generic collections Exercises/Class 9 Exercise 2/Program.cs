using System.Diagnostics;

namespace Class_9_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2
            Console.WriteLine("Exercise 2");
            /*
            Create a class Song with the following properties: Title, Length and, Genre
            ● Genre is enum with - Rock, Hip_Hop, Techno and Classical
            ● Create a class Person with the following properties: Id, FirstName, LastName, Age,
            FavoriteMusicType (Genre enum) and FavoriteSongs
            ● FavoriteSongs is a list of Songs
            ● Create a method called GetFavSongs() that will print out all
            the titles of their favorite songs or write a message 
            that this person hates music if there are no favorite songs in their list
            */

            // ListS
            List<Song > songsOneFav = new List<Song>();
            List<Song> songsTwoFav = new List<Song>();
            List<Song> songsThreeFav = new List<Song>();
            List<Song> songsFourFav = new List<Song>();
            List<Song> songsHaterFav = new List<Song>();

            // Songs
            Song one = new Song("Bohemian Rhapsody",5.55M,EnumGenre.Rock);
            songsOneFav.Add(one);
            Song two = new Song("Stairway to Heaven", 7.55M, EnumGenre.Rock);
            songsOneFav.Add(two);
            Song three = new Song("Numb", 3.06M, EnumGenre.Rock);
            songsOneFav.Add(three);
            Song four = new Song("The Message, 1982", 7.10M, EnumGenre.Hip_Hop);
            songsTwoFav.Add(four);
            Song five = new Song("\"Rapper's Delight\"", 3.10M, EnumGenre.Hip_Hop);
            songsTwoFav.Add(five);
            Song six = new Song("Planet Rock", 6.55M, EnumGenre.Hip_Hop);
            songsTwoFav.Add(six);
            Song seven = new Song("No UFOs", 6.47M, EnumGenre.Techno);
            songsThreeFav.Add(seven);
            Song eight = new Song("Good Life – Inner City", 4.03M, EnumGenre.Techno);
            songsThreeFav.Add(eight);
            Song nine = new Song("Energy Flash – Joey Beltram", 5.50M, EnumGenre.Techno);
            songsThreeFav.Add(nine);
            Song ten = new Song("Mozart – Eine kleine Nachtmusik", 16.20M, EnumGenre.Classical);
            songsFourFav.Add(ten);
            Song eleven = new Song("Beethoven – Für Elise", 12.47M, EnumGenre.Classical);
            songsFourFav.Add(eleven);
            Song twelve = new Song("Vivaldi – The Four Seasons", 11.20M, EnumGenre.Classical);
            songsFourFav.Add(twelve);

            // Person
            Person raper = new Person(1, "Marko", "Gigoski", 31, EnumGenre.Hip_Hop, songsTwoFav);
            Person techNar = new Person(2, "Kristina", "Gigoska", 30, EnumGenre.Techno, songsThreeFav);
            Person rocker = new Person(3, "Borjan", "Gigoski", 15, EnumGenre.Rock, songsOneFav);
            Person clasiKa = new Person(4, "Sofija", "Malinovska", 45, EnumGenre.Classical, songsFourFav);
            Person hejteR = new Person(5, "Marjan", "Gigoski", 54, EnumGenre.Hater, songsHaterFav);

            // Method
            raper.GetFavSongs(songsTwoFav);
            techNar.GetFavSongs(songsThreeFav);
            rocker.GetFavSongs(songsOneFav);
            clasiKa.GetFavSongs(songsFourFav);
            hejteR.GetFavSongs(songsHaterFav);

            // Exercise 3
            Console.WriteLine("Exercise 3");
            /*
            ● Select the person Jerry and add all the songs which start with the letter B
            ● Select the person Maria and add all the songs with length longer than 6 mins
            ● Select the person Jane and add all the songs that are of genre Rock
            ● Select the person Stefan and add all songs shorter than 4 mins and of genre Hip-Hop
            ● Select all persons from the persons array that have 3 or more songs
            */

            List<Song> linqSongList = new List<Song>()
            {
                one,
                two,
                three,
                four,
                five,
                six,
                seven,
                eight,
                nine,
                ten,
                eleven,
                twelve
            };
            
            // just cheking for myself something
            foreach(Song s in linqSongList)
            {
                Console.WriteLine(s.Title);
            }

            Person jerry = new Person(101, "Jerry", "Jerevski", 15, EnumGenre.Classical,linqSongList);
            jerry.FavouriteSong = linqSongList.Where(x => x.Title.StartsWith('B')).ToList();

            Person maria = new Person(201, "Maria", "Marievska", 30, EnumGenre.Techno, linqSongList);
            maria.FavouriteSong = linqSongList.Where(x => x.Lenght > 6.0M).ToList();

            Person jane = new Person(301, "Jane", "Janevska", 45, EnumGenre.Rock, linqSongList);
            jane.FavouriteSong = linqSongList.Where(x => x.Genre == EnumGenre.Rock).ToList();

            Person stefan = new Person(302, "Stefan", "Stefanovski", 60, EnumGenre.Hip_Hop, linqSongList);
            stefan.FavouriteSong = linqSongList.Where(x => x.Lenght < 4.0M && x.Genre == EnumGenre.Hip_Hop).ToList();

            List<Person> friends = new List<Person>() { jerry, maria, jane, stefan };
            List<Person> selectedFriends = friends.Where(x => x.FavouriteSong.Count >= 3).ToList();
            


            










        }
    }
}
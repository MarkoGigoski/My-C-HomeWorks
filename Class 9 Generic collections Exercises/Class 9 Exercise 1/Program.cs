namespace Class_9_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1");
            /*
            ● Create a PhoneBook Dictionary with 5 names and phone numbers.
            ● Through the console ask the person to enter a name.
            ● Try and find that names phone number in your PhoneBook
            ● If you can find it, print it in the console
            ● If you can’t, print an error message
            */

            Dictionary<string, long> phoneBook = new Dictionary<string, long>()
            {
                {"Marko", 070321556},
                {"Kristina", 078556321},
                {"Borjan", 078664422},
                {"Sofija", 077521447},
                {"Marjan", 070458712}

            };
           
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            foreach(KeyValuePair<string, long> i in phoneBook)
            {
                if (name == i.Key)
                {
                    Console.WriteLine(i.Value);
                }
                else
                {
                    Console.WriteLine("Error MsG");
                }
            }

        }
    }
}
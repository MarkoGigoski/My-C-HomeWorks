namespace last_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3
            Console.WriteLine("Exercise 3");
            /*
            ● In the existing Console Application create a new method called Substrings
            ● In that method enter the following string : "Hello from SEDC Codecademy 2023"
            ● Ask the user to enter a number n.
            ● Print the first n characters from that string and print the length of the new string.
            ● Try to handle all the scenarios
            */

            string sentence = "Hello from SEDC Codecademy 2023";
            
            while (true)
            {
                Console.WriteLine("Enter a number between 1 and 30");
                string stringInput = Console.ReadLine();
                int n;
                bool inputToBool = int.TryParse(stringInput, out n);

                if (n >= 30)
                {
                    Console.WriteLine("You enter a wrong input, enter a number between 1 and 30 again");
                    continue;

                }
                else
                {
                    Console.WriteLine($"{n} first Characters will be: {sentence.Substring(0, n)}" );
                    Console.WriteLine($"The rest Characters will be: {sentence.Substring(n + 1)}");
                    return;
                }
            }

            // Exercise 4
            Console.WriteLine("Exercise 4");
            /*
            ● Print the date that is 3 days from now
            ● Print the date that is one month from now
            ● Print the date that is one month and 3 days from now
            ● Print 1 year and 2 months ago from today
            ● Print only the current month of today
            ● Print only the current year of today
            */

            // days from now
            DateTime date1 = DateTime.Now;
            date1.AddDays(3);

            // month from now
            date1.AddMonths(1);

            // month and 3 days from now
            date1.AddMonths(1).AddDays(3);

            // 1 year and 2 months ago
            date1.AddYears(-1).AddMonths(-2);

            // current month of today
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            // current year of today
            Console.WriteLine(date1.Year);

            // This is the last two exercises from Class 4, previuose i just sended 2.

            









        }
    }
}
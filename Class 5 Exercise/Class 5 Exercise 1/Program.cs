namespace Class_fo_Classes_Exercisessss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1");
            /*
            ● Create a class Human
            ● Add properties: FirstName, LastName, Age
            ● Create a method called GetPersonStats that returns the full name of the human as well as their age
            ● Create an object human by asking the user to fill the required information
            ● Call the GetPersonStats method and print the result in the console after the object is created
            */

            Console.WriteLine("Enter your first name");
            string inputFirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            string inputLastName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            string stringInputAge = Console.ReadLine();
            int inputAge;
            bool inputAgeToBool = int.TryParse(stringInputAge, out inputAge);

            Human h1 = new Human();
            h1.FirstName = inputFirstName;
            h1.LastName = inputLastName;
            h1.Age = inputAge;
            Console.WriteLine(h1.GetPersonStats());
            Console.ReadLine();


            

        }

       
    }

}
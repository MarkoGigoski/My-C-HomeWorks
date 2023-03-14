using System.Security.Cryptography.X509Certificates;

namespace Vezbi_od_Class_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1");
            /*
            ● Create 2 methods called Sum and Subtract
            ● Sum will accept two numbers as parameters and return a result from summing the two numbers
            ● Subtract will accept two numbers as parameters and return a result from subtracting the two number
            ● Ask a person from the console to enter - or +
            ● Then ask the person to enter two numbers
            ● Call the corresponding method ( sum or subtract ) and return the result to the console
            */


            int sumFunction(int one, int two)
            {
                return one + two;
            }

            int subFunction(int one, int two)
            {
                return one - two;
            }

            Console.WriteLine("Prees one of the operations - or + please");
            string stingInput1 = Console.ReadLine();

            Console.WriteLine("Enter first number");
            string stingInput2 = Console.ReadLine();
            int input2;
            bool input2ToBool = int.TryParse(stingInput2, out input2);

            Console.WriteLine("Enter second number");
            string stringInput3 = Console.ReadLine();
            int input3;
            bool input3ToBool = int.TryParse(stringInput3, out input3);

            if(stingInput1 == "-")
            {
                Console.WriteLine($"Sub result: {subFunction(input2,input3)}");
            }
            else if(stingInput1 == "+")
            {
                Console.WriteLine($"Sum result: {sumFunction(input2, input3)}");
            }
            else
            {
                Console.WriteLine("You choose wrong operater dummy GO HOME!");
            }

            // Exercise 2
            Console.WriteLine("Exercise 2");
            /*
            ● Try writing these strings in the console:
            ▹ Check your c:\ drive
            ▹ We will have "fair" elections
            ▹ The \n sign means: new line
            */
            Console.WriteLine("Check your c:\\ drive");
            Console.WriteLine("We will have \"fair\" elections");
            Console.WriteLine("The \\n sign means: new line");

            // Exercise 3
            Console.WriteLine("Exercise 3");
            /*
            ● In the existing Console Application create a new method called Substrings
            ● In that method enter the following string : "Hello from SEDC Codecademy 2023"
            ● Ask the user to enter a number n.
            ● Print the first n characters from that string and print the length of the new string.
            ● Try to handle all the scenarios.
            */

            string sentence = "Hello from SEDC Codecademy 2023";
            int substrings;

            Console.WriteLine("Please enter a number");
            string stringInput4 = Console.ReadLine();
            int input4;
            bool input4ToBool = int.TryParse(stringInput4, out input4);

        }
        // ill do the bonus and the last 2 from presentation as soon as i have time this week with the rest of todays calss 6 :)
    }
}
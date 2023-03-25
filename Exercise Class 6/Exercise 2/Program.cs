using System.ComponentModel.Design;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            Console.WriteLine("Exercise 2");
            /*
            Create a method called NumberStats that accepts a number. This method should:
            - Find out if the number is negative or positive
            - Find out if the number is odd or even
            - Find out if the number is decimal or integer
            After finding all the stats it should print them like this:
            Stats for number: 25
            * Positive
            * Integer
            * Odd
            The number should be entered in the console by the user.
            - Bonus: Validate if the user is entering a number
            - Bonus: Ask the user to press Y to try again or X to exit
            */

            void NumberStats(decimal number)
            {
                Console.WriteLine($"Stats for the number: {number}");
                if (number < 0)
                {
                    Console.WriteLine("* Negativ");
                }
                else if(number > 0)
                {
                    Console.WriteLine("* Positiv");
                }
                else
                {
                    Console.WriteLine("Neither, probubly 0");
                }

                if (number % 1 == 0)
                {
                    Console.WriteLine("* Integer");
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("* Even");
                    }
                    else
                    {
                        Console.WriteLine("* Odd");
                    }
                }
                else
                {
                    Console.WriteLine("* Decimal");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter a number please");
                string intString = Console.ReadLine();
                decimal numberInput;
                Decimal.TryParse(intString, out numberInput);


                //something like a number validation:)
                if (numberInput - numberInput == 0 || numberInput - numberInput != 0)
                {
                    NumberStats(numberInput);
                }

                Console.WriteLine("Press Y to try again with a diferent number or X for exit please");
                string continiuneValidation = Console.ReadLine();

                if (continiuneValidation == "Y" || continiuneValidation == "y")
                {
                    continue;
                }
                else if (continiuneValidation == "X" || continiuneValidation == "x")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered a wrong input, the program will be stoped");
                    return;
                }
            }
           
        }
    }
}
namespace Vezbi_od_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1");
            /*
            ● Declare two double variables
            ● Initialize them and divide them in a new variable
            ● Declare two integer variables
            ● Initialize them and divide them in a new variable
            ● Print the results in the console and compare
            */

            double first = 44.4;
            double second = 22.2;
            double divDouble = first / second;
            Console.WriteLine(divDouble);

            int one = 50;
            int two = 10;
            int divInt = one / two;
            Console.WriteLine(divInt);

            // Exercise 2
            Console.WriteLine("Exercise 2");
            /*
            ● Declare two string variables
            ● Initialize them and concatenate them in a new variable
            ● Declare two string variables
            ● Initialize them with the number 9 and 3
            ● Concatenate them in a new variable
            ● Print the results in the console
            */

            string stringOne = "Marko";
            string stringTwo = "Gigoski";
            string concatStrings = $"{stringOne} {stringTwo}";
            Console.WriteLine(concatStrings);

            string firstNumber;
            string secondNumber;
            firstNumber = "9";
            secondNumber = "3";
            string concatStringTwo = $"First numebr: {firstNumber}, Second number: {secondNumber}";
            Console.WriteLine(concatStringTwo);

            // Exercise 3
            Console.WriteLine("Exercise 3");
            /*
            ● Declare an integer and a string variable
            ● Initialize them and concatenate them in a new variable
            ● Print the result in the console
            */

            int number = 30;
            string name = "Kristina";
            string stringifiedInt = number.ToString();
            string concatIntegerAndString = stringifiedInt + " " + name;
            Console.WriteLine(concatIntegerAndString);

            // Exercise 4
            Console.WriteLine("Exercise 4");
            /*
            ● You have n credits on your mobile bill. One SMS costs m credits. How many SMS messages you can send?
            ● n = 102
            ● m = 5
            ● Result = ?
            */

            int n = 102;
            int m = 5;
            int result = n / m;
            Console.WriteLine($"You can send {result} messages");

            // Exercise 5
            Console.WriteLine("Exercise 5");
            /*
            Solve the following problem. On one tree there are 12 branches with k apples on them. One basket can hold m apples.
            If a user enters number of trees find out how many baskets does it take to collect all the apples from the trees?
            ● k = 8
            ● m = 5
            Result = ?
            */

            int branches = 12;
            int k = 8;
            int basketM = 5;

            Console.WriteLine("Enter numebr of trees");
            string trees = Console.ReadLine();

            int treesIntToBe;
            bool treesIntSuccess = int.TryParse(trees, out treesIntToBe);

            Console.WriteLine($"It will take: {treesIntToBe * branches * k / (basketM)} backets to collect the apples from {treesIntToBe} trees!");

            // Exercise 6
            Console.WriteLine("Exercise 6");
            /*
            ● Create two variables and initialize them with a keyboard input
            ● Write code that can test which number is larger
            ● Write code that can test the numbers whether they are even or odd
            ● Write the larger number from the two in the console
            ● After that write if the number is even or odd
            */

            // first input
            Console.WriteLine("Type first number: ");
            string firstNumber1 = Console.ReadLine();
            int firstNumber1Int;
            bool firstNuberOne1Bool = int.TryParse(firstNumber1, out firstNumber1Int);

            // second input
            Console.WriteLine("Type second number: ");
            string secondNumber2 = Console.ReadLine();
            int secondNumber2Int;
            bool secondNumberTwo2Bool = int.TryParse(secondNumber2, out secondNumber2Int);

            if(firstNumber1Int > secondNumber2Int)
            {
                if(firstNumber1Int % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber1Int} EVEN");
                }
                else
                {
                    Console.WriteLine($"{firstNumber1Int} ODD");
                }
            }
            else
            {
                if(secondNumber2Int % 2 == 0)
                {
                    Console.WriteLine($"{secondNumber2Int} EVEN");
                }
                else
                {
                    Console.WriteLine($"{secondNumber2Int} ODD");
                }
            }

            // Exercise 7
            Console.WriteLine("Exercise 7");
            /*
            ● Ask the user to enter a number from 1 to 3
            ● If the user enters “1” write “You got a new car!”
            ● If the user enters “2” write “You got a new plane!”
            ● If the user enter “3” write “You got a new bike!”
            ● If the user enters a wrong number or character write an error message in the console
            */

            Console.WriteLine("Enter a number from 1 to 3");
            string num = Console.ReadLine();
            int numToBeInt;
            bool numberToBeBool = int.TryParse(num, out numToBeInt);

            switch (numToBeInt)
            {
                case 1:
                    Console.WriteLine("You go a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("You neeed to enter a number from 1 to 3!");
                    break;
            }
        }
    }
}
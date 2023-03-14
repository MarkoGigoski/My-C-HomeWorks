namespace Vezbi_class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1");
            /*
            ● Get an input number from the console
            ● Print all numbers from 1 to that number
            ● Get another input number from the console
            ● Print all numbers from that number to 1
            */

            Console.WriteLine("Type a number from 10 to 30!");
            string stringInput1 = Console.ReadLine();
            int input1;
            bool input1ToBool = int.TryParse(stringInput1, out input1);

            for (int i = 1; i <= input1; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Type a number from 20 to 40!");
            string stringInput2 = Console.ReadLine();
            int input2;
            bool input2ToBool = int.TryParse(stringInput2, out input2);

            for (int i = input2; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // Exercise 2
            Console.WriteLine("Exercise 2");
            /*
            ● Get an input number from the console
            ● Print all even numbers starting from 2
            ● Get another input number from the console
            ● Print all odd numbers starting from 1
            */
            Console.WriteLine("Type a number from 2 to 100");
            string stringInput3 = Console.ReadLine();
            int input3;
            bool input3ToBool = int.TryParse(stringInput3, out input3);

            for (int i = 2; i <= input3; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Type a number from 1 to 100");
            string stringInput4 = Console.ReadLine();
            int input4;
            bool input4ToBool = int.TryParse(stringInput4, out input4);

            for (int i = 1; i <= input4; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Exercise 3
            Console.WriteLine("Exercise 3");
            /*
            ● Get an input from the console
            ● Print all numbers from 1 to that number
            ● Don’t print numbers that can be divided by 3 or 7
            ● If the number gets to 100 print a message: The limit is reached and stop counting
            */
            Console.WriteLine("Type a number");
            string stringInput5 = Console.ReadLine();
            int input5;
            bool input5ToBool = int.TryParse(stringInput5, out input5);

            for (int i = 1; i <= input5; i++)
            {

                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                    if (i == 100)
                    {
                        Console.WriteLine("The limit is reached!");
                        break;

                    }
                }
            }

            // Exercise 4
            Console.WriteLine("Exercise 4");
            /*
            ● Declare 5 arrays with 5 elements in them:
            ▹ With words
            ▹ With decimal values
            ▹ With characters from keyboard
            ▹ With true/false values
            ▹ With arrays, each holding 2 whole numbers
            */
            string[] withWords = new string[5] { "Marko", "Kristina", "Borjan", "Sofija", "Marjan" };
            decimal[] withDecimals = new decimal[5] { 22.22m, 33.33m, 44.44m, 55.55m, 66.66m };
            char[] withCharacters = new char[5] { 'A', 'B', 'C', 'D', 'F' };
            bool[] withBolian = new bool[5] { true, false, false, true, false };
            int[,] withArrays = new int[5, 2] { { 10, 20 }, { 30, 40 }, { 50, 60 }, { 70, 80 }, { 90, 100 } };

            // Exercise 5
            Console.WriteLine("Exercise 5");
            /*
            ● Declare a new array of integers with 5 elements
            ● Initialize the array elements with values from input
            ● Sum all the values and print the result in the console
            */
            int[] inetgersArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number: ");
                inetgersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int number in inetgersArray)
            {
                sum += number;
            }
            Console.WriteLine($"The sum from all the elements from our array is: {sum}");

            // Exercise 6
            Console.WriteLine("Exercise 6");
            /*
            ● Create an array with names
            ● Give an option to the user to enter a name from the keyboard
            ● After entering the name put it in the array
            ● Ask the user if they want to enter another name(Y / N)
            ● Do the same process over and over until the user enters N
            ● Print all the names after user enters N
            */
            string[] arrayOfNames = new string[0];

            while (true)
            {
                Console.WriteLine("Enter a Name: ");
                string name = Console.ReadLine();

                Array.Resize(ref arrayOfNames, arrayOfNames.Length + 1);
                arrayOfNames[arrayOfNames.Length - 1] = name; //

                Console.WriteLine("If you want to add another name press Y/y, else press N/n");
                string chekInput = Console.ReadLine();

                if (chekInput == "Y" || chekInput == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            foreach (string name in arrayOfNames)
            {
                Console.WriteLine($"arrayOfNames: {name}");
            }
        }
    }
}
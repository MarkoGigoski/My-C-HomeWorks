namespace Class_of_Classes_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2
            Console.WriteLine("Exercise 2");
            /*
            ● Create a class Dog
            ● Add properties: Name, race, color
            ● The dog needs to have an Eat method that returns
            message: The dog is now eating. A Play method returning a
            message : The dog is now playing. and a ChaseTail method
            that returns a message: Dog is now chasing its tail. 
            ● The user needs to create the dog object by inputs
            and then given an option to choose one of the actions mentioned above.
            */

            Console.WriteLine("What is the name of your dog?");
            string dogName = Console.ReadLine();

            Console.WriteLine("What race is your dog?");
            string dogRace = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string dogColor = Console.ReadLine();

            Dog myDog = new Dog();
            myDog.Name = dogName;
            myDog.Color = dogColor;
            myDog.Race = dogRace;

            while (true)
            {
                Console.WriteLine("What is the thing your dog wants to do the most? (Pick a number from 1-3) \n 1. Eat \n 2. Play \n 3. Chais tail");
                string input123 = Console.ReadLine();

                if (input123 == "1")
                {
                    Console.WriteLine(myDog.Eat());
                    break;
                }
                else if (input123 == "2")
                {
                    Console.WriteLine(myDog.Play());
                    break;
                }
                else if (input123 == "3")
                {
                    Console.WriteLine(myDog.ChaseTail());
                    break;
                }
                else
                {
                    Console.WriteLine("You enter wrong input! Try again");
                    continue;

                }
            }



        }
    }
}
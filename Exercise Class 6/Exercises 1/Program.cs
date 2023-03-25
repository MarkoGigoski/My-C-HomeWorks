namespace Exercises_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Exercise 1");
            /*
            You are given the following string:
            - "The whole group of G2 loves C#.They find learning this language fun and easy!".
            Print the text after the ".", using string methods.
            */

            string sentence = "The whole group of G2 loves C#.They find learning this language fun and easy!";

            int index = sentence.IndexOf(".") + 1;
            string result = sentence.Substring(index);

            Console.WriteLine(result);


        }
    }
}
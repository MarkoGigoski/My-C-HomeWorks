namespace Class_of_Classes_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3
            Console.WriteLine("Exercise 3");
            /*
            ● Create a class Student that has properties: Name, Academy and Group
            ● Create an array with 5 new Students ( objects )
            ● The user should enter a name and the user information 
            should be displayed in the console if a user by that name exists
            ● If there is no such user it should show an error message
            */

            // Student 1
            Student student1 = new Student("Marko Gigoski", "SEDC", "G7");

            // Student 2
            Student student2 = new Student("Kristina Gigoska", "Brainstern", "A5");


            // Student 3
            Student student3 = new Student("Borjan Gigoski", "SEDC", "G3");

            // Student 4
            Student student4 = new Student("Sofija Malinovska", "Code Academy", "Z5");

            // Student 5
            Student student5 = new Student("Marjan Ristevski", "SEDC", "G4");

            // Array of students
            Student[] arrayOfStudents = new Student[5] { student1, student2, student3, student4, student5 };
            
            Console.WriteLine("Enter student name.");
            string studentName = Console.ReadLine();

            bool studentFound = false;

            for(int i = 0; i < arrayOfStudents.Length; i++)
            {
                if (arrayOfStudents[i].Name == studentName)
                {
                    Console.WriteLine($"Ther is a student that mach: {arrayOfStudents[i].GetStudentInfo()}");

                }
            }

            


        }
    }
}
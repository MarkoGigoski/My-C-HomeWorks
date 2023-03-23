namespace Class_fo_Classes_Exercisessss
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} is {Age} years old!";
        }
    }
}

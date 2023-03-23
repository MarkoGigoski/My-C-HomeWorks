namespace Class_of_Classes_Exercise_2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Race { get; set; }

        public string Eat()
        {
            return $"The dog is now eating";
        }

        public string Play()
        {
            return $"The dog is now playing";
        }

        public string ChaseTail()
        {
            return "Dog is now chasing its tail";
        }

    }
}

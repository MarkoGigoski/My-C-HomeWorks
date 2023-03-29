namespace Class_9_Demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            // Dictionary
            Console.WriteLine("DICTIONARY");
            // Dictionary is a generic function that takes two types and two values. 

            // {["070321556", "Risto"],["070556774","Tijana"]}
            Dictionary<long, string> people = new Dictionary<long, string>();



            Dictionary<int, Student> students = new Dictionary<int, Student>();
            // Examples from filing a Dictionary Student
            Student s1 = new Student() { FirstName = "Risto", LastName = "Pancevski" };
            students.Add(1001, s1);

            Student s2 = new Student() { FirstName = "test", LastName = "test" };
            students.Add(1002, s2);
            //We can only axes the index of Dictionary, only with the key:
            Student name = students[1002];// istead of index we add KEY

            // Each element inside a  DICTIONARY must have its own key-value PARI!
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("+38970123456", "Risto");
            //We can only axes the index of Dictionary, only with the key: second example
            string name1 = phoneBook["+38970123456"];

            //How we iterate inside dictionarys itn
            foreach (KeyValuePair<string, string> e in phoneBook)
            {
                Console.WriteLine($"{e.Value} - {e.Key}");
            }

            foreach (KeyValuePair<int, Student> e in students)
            {
                Console.WriteLine($"{e.Key} - {e.Value.FirstName} - {e.Value.LastName}");
            }

            // string n = phonebook["123123123"]; -> ERROR
            // In order not to have error because the key does not exist we have a method in order to chek that:
            bool keyExist = phoneBook.ContainsKey("123123123");
            if (keyExist)
            {
                string n = phoneBook["123123123"];
            }

            // Some methods for dictionarys
            Dictionary<string, int> plClubs = new Dictionary<string, int>()
            {
                {"Arsenal",0 },
                {"Manchester City",0 },
                {"Manchester United",0 }
            };
            Console.WriteLine($"{plClubs.Count}"); // counting
            plClubs.Remove("Manchester City");// remove
            Console.WriteLine($"{plClubs.Count}");
            bool successAdd = plClubs.TryAdd("Chelsea", 0);// adding
            #endregion

            #region List
            // List
            Console.WriteLine("List");

            // creating a List, we dont have key value pair only Data TYPE
            List<string> animals = new List<string>();
            animals.Add("Cat");
            animals.Add("Dog");
            //we can even put same elements duplicats LIST is the most flexiable
            animals.Add("Cat");
            animals.Add("Tiger");

            // diferent filling style
            List<int> evenNumbers = new List<int>() { 2, 4, 6, 8, 10, 12 };
            Console.WriteLine(evenNumbers[2]); // we can axess them with index like arrays
            evenNumbers[3] = 14;// overwrite them as array aswell

            /*Console.WrtiteLine(evenNumbers[8]); */// will throw an error because that element on that index does not exists

            evenNumbers.Add(16);
            evenNumbers.Add(18);
            evenNumbers.Add(20);

            bool exist = evenNumbers.Contains(12);
            evenNumbers.RemoveAt(4);
            evenNumbers.RemoveRange(2, 3); //removes from 2element with it itels +2, baisicly 3 elements with the 2
            bool successfullRemove = evenNumbers.Remove(12);

            Console.WriteLine(evenNumbers.Count); // count the lemenets withing the List

            List<Student> studentList = new List<Student>();
            // first examample from studentList
            studentList.Add(new Student()
            {
                FirstName = "1",
                LastName = "1"
            });
            // second example from studentList
            studentList.Add(new Student()
            {
                FirstName = "2",
                LastName = "2"
            });

            foreach(Student s in studentList)
            {
                Console.WriteLine(s.GetFullName());
            }

            List<Student> studentList1 = new List<Student>();
            // first examample from studentList1
            studentList1.Add(new Student()
            {
                FirstName = "3",
                LastName = "3"
            });
            // second examample from studentList1
            studentList1.Add(new Student()
            {
                FirstName = "4",
                LastName = "4"
            });
            // Itaration for list
            foreach(Student s in studentList1)
            {
                Console.WriteLine(s.GetFullName());
            }
            // merging two lists
            studentList1.AddRange(studentList);
            Console.WriteLine("---AFTER mrging---");
            // iteration  after merg
            foreach(Student s in studentList1)
            {
                Console.WriteLine(s.GetFullName());
            }
            #endregion

            #region Queue (FIFO) - first in first out
            // Queue
            Console.WriteLine("Queue");

            Queue<decimal> decimals = new Queue<decimal>();
            // we canot access them with idnex, Queue elements.

            decimals.Enqueue(11.1M);// we add it with keyWords Enqueue.
            decimals.Equals(22.2M);
            decimals.Equals(33.3M);
            decimals.Equals(44.4M);
            decimals.Equals(55.5M);
            decimals.Equals(66.6M);

            decimal d1 = decimals.Dequeue();// first item that we have stored,
            // inside the List will be return to us and it will be removed with the .Dequeue method.
            decimal d2 = decimals.Dequeue(); // will return it and then preccese it
            decimal d3 = decimals.Dequeue();

            /*decimal d4 = decimals.Dequeue();*/ // if we want to Dequeue when we dont have anything inside the List
            // it will throw an error.

            bool successDequeue = decimals.TryDequeue(out decimal d4);// method to see if there is an element d4,
            // to be removed, if its fals nothing if its true it will be Dequeue.

            decimal d5 = decimals.Peek(); //it will peek what is the next one for us, always give us,
            //the first one that we entered or the first one that is after we removed some:)
            bool successPeak = decimals.TryPeek(out decimal d55); //
            #endregion

            #region Stack (LIFO) - last in first out
            // Stack
            Console.WriteLine("Stack");

            Stack<string> cars = new Stack<string>();
            cars.Push("BMW"); // Push is for entering elements inside the STACK
            cars.Push("Renault");
            cars.Push("Tesla");

            string car1 = cars.Pop(); //Gives you the next element, but based on last in First out and then removes it
            string car2 = cars.Pop();
            string car3 = cars.Pop();
            string car4 = cars.Pop();

            bool successCarReturn = cars.TryPop(out string car5);

            string car6 = cars.Peek();
            bool successPeakCar = cars.TryPeek(out string car7);
            #endregion

           
      



        }
    }
}
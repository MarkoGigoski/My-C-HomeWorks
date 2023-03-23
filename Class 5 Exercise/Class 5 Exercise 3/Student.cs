using System.Security.Cryptography.X509Certificates;

namespace Class_of_Classes_Exercise_3
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string name,string academy,string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string GetStudentInfo()
        {
            return $"{Name} - {Academy} - {Group}";
        }
       
    }
}

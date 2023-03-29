using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9_Demo_1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName}{LastName}";
        }
    }
}

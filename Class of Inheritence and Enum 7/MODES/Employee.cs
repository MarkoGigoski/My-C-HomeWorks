namespace MODES
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, RoleEnum role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} - {Salary}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }


    }
}
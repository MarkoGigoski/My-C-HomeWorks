using MODES;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1");
            /*
             * PART |
             * 
            ● Create a class library project and in it create all classes
            ● Create a class called Employee with the following properties:
              ▹ FirstName
              ▹ LastName
              ▹ Role - Enum ( Sales, Manager, Other )
              ▹ Salary - protected, double
            ● Create two methods:
              ▹ PrintInfo - Prints FirstName, LastName and Salary
              ▹ GetSalary - returns the salary
             *
             * PART ||
             * 
            ● Create a SalesPerson class that inherits from Employee and has the 
            following properties:
              ▹ SuccessSaleRevenue double, private
              ▹ The salary is by default 500 and role is default Sales
            ● Create constructor that sets all the properties
            ● Create a method called AddSuccessRevenue that will get a number and
            set the SuccessSaleRevenue to that value
            ● Override the GetSalary method to return the value of the salary plus
            bonus that is calculated by the SuccessSaleRevenue.
              ▹ If less or equal to 2000 then add 500 bonus
              ▹ If larger than 2000 but less or equal than 5000 then add 1000 bonus
              ▹ If larger than 5000 add 1500 bonus
             * 
             * PART ||
             * 
            ● Add class Manager that inherits from Employee and has a
            new property called Bonus - double, private
            ● Create a constructor that sets all properties except Bonus
            ● Create a method called AddBonus that adds bonus to the
            Bonus property
            ● Override the method GetSalary to return the Salary + Bonus
            */

            SalesPerson person1 = new SalesPerson("Marko", "Gigoski");
            SalesPerson person2 = new SalesPerson("Kristina", "Gigoska");

            Menager boss = new Menager("Tijana", "Stojanovska", 1500);

            person1.AddSuccessRevenue(700);
            person2.AddSuccessRevenue(500);

            person1.AddSuccessRevenue(1600);
            person2.AddSuccessRevenue(2200);

            boss.AddBonus(500);

            Console.WriteLine(person1.GetInfo());
            Console.WriteLine(person2.GetInfo());
            Console.WriteLine(boss.GetInfo());

            Employee newEmployee = new Employee("Borjan", "Gigoski", RoleEnum.Sales, 800);
            Console.WriteLine(newEmployee.GetInfo());

            // Dechki mnogu me interesira zosto addravenue i add bonus ne mi funkcioniraa tuka i kade mi bese greshkata:(



        }
    }
}
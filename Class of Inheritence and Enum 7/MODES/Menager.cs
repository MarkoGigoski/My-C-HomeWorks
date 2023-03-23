namespace MODES
{
    public class Menager : Employee
    {
        private double Bonus { get; set; }

        public Menager(string firstName,string lastName, double salary)
            :base(firstName,lastName, RoleEnum.Menager,salary)
        {
            Bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }

    }
}

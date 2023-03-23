using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace MODES
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstName, string lastName) :
            base(firstName,lastName,RoleEnum.Sales,500)
        {
            SuccessSaleRevenue = 0;
        }

        public void AddSuccessRevenue(double ravenue)
        {
            SuccessSaleRevenue += ravenue;
        }

        public override double GetSalary()
        {
            double baisicSalary = base.GetSalary();
            double salaryWithBonus = 0;

            if (SuccessSaleRevenue <= 2000)
            {
                salaryWithBonus = baisicSalary + 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                salaryWithBonus = baisicSalary + 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                salaryWithBonus = baisicSalary + 1500;
            }

            return salaryWithBonus;
        }
    }
}

//Maintanence workers have Extra $100 Over the whole Salary;
using System;

namespace WageCalculation
{
    public sealed class Maintanence : Employee
    {
        public Maintanence(int _id, string _name, decimal _wageperhour, int _loggedhours) : base(_id, _name, _wageperhour, _loggedhours) { }

        private const decimal Bouns = 100m;
        private decimal CalculateSalaryAfterBouns()
        {
            return base.CalculateSalary() + Bouns;
        }
        public override string ToString()
        {
            return
                base.ToString() +
                $"Bouns: ${Bouns}\n" +
                $"Salary After Bouns: ${Math.Round(CalculateSalaryAfterBouns(), 2)}\n";
        }
    }
}

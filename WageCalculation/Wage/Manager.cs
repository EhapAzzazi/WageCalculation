//Manager Has Extra 0.15 Over the whole Salary
using System;


namespace WageCalculation
{
    public sealed class Manager: Employee
    {
        public Manager(int _id, string _name, decimal _wageperhour, int _loggedhours) : base(_id, _name, _wageperhour, _loggedhours) {  }

        private const decimal Bouns = 0.15m;
        private decimal CalculateBouns()
        {
            return base.CalculateSalary() * Bouns;
        }
        private decimal CalculateSalaryAfterBouns()
        {
            return base.CalculateSalary() + CalculateBouns();
        }
        public override string ToString()
        {
            return 
                base.ToString() +
                $"Bouns: ${ Math.Round(CalculateBouns(), 2)}\n" +
                $"Salary After Bouns: ${Math.Round(CalculateSalaryAfterBouns(), 2)}\n";
        }
    }
}

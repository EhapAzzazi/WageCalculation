//Programmers have Extra 0.1 Over the whole Salary;
using System;

namespace WageCalculation
{
    public sealed class Programmer : Employee
    {
        public Programmer(int _id, string _name, decimal _wageperhour, int _loggedhours,bool _taskcompleted) : base(_id, _name, _wageperhour, _loggedhours)
        {
            this.TaskCompleted = _taskcompleted;
        }
        private bool TaskCompleted;
        private const decimal Bouns = 0.1m;
        private decimal CalculateBouns() => TaskCompleted ? base.CalculateSalary() * Bouns : 0;
        private string CheckBouns()
        {
            string OK = 
                $"Bouns: ${ Math.Round(CalculateBouns(), 2)}\n" +
                $"Salary After Bouns: ${Math.Round(CalculateSalaryAfterBouns(), 2)}\n";
            if (CalculateBouns() != 0)
            {
                return OK;
            }
            else
            {
                return Environment.NewLine;
            }
        }
        private decimal CalculateSalaryAfterBouns()
        {
            return base.CalculateSalary() + CalculateBouns();
        }
        public override string ToString()
        {
            return
                base.ToString() +
                CheckBouns();
        }
    }
}

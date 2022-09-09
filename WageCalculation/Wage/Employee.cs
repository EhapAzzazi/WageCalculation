using System;

namespace WageCalculation
{
    public class Employee
    {
        private const int MinimumLoggedHours = 176;
        private const int MinimumWagePerHours = 10; // $10
        private const decimal ExtraHoursPercent = 1.25m;

        protected int ID { get; }
        protected string Name { get; }
        protected decimal WagePerHour { get; }
        protected int LoggedHours { get; }
        public Employee(int _id,string _name, decimal _wageperhour = MinimumWagePerHours, int _loggedhours = MinimumLoggedHours)
        {
            this.ID = _id;
            this.Name = _name;
            this.WagePerHour = _wageperhour;
            this.LoggedHours = _loggedhours;
        }
        protected virtual decimal CalculateSalary()
        {
            return CalculateBasicSalary() + CalculateExtraSalary();
        }
        protected virtual decimal CalculateBasicSalary()
        {
            return (WagePerHour * LoggedHours);
        }
        protected virtual decimal CalculateExtraSalary()
        {
            var additionalhours = (LoggedHours - MinimumLoggedHours) > 0 ? (LoggedHours - MinimumLoggedHours) : 0;

            return additionalhours * ExtraHoursPercent;
        }
        public override string ToString()
        {
            string Title = $"**********{this.GetType().Name}**********\n";
            return
                Title +
                $"ID: {this.ID}\n" +
                $"Name: {this.Name}\n" +
                $"LoggedHours: {this.LoggedHours} hrs\n" +
                $"Basic Salary: ${Math.Round(this.CalculateBasicSalary(), 2)}\n" +
                $"Extra Salary: ${Math.Round(this.CalculateExtraSalary(), 2)}\n" +
                $"Net Salary: ${Math.Round(this.CalculateSalary(), 2)}\n";

        }
    }
    
}

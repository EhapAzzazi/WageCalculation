//Salesmen have commission = $1 per 1 piece;
using System;

namespace WageCalculation
{
    public sealed class Sales : Employee
    {
        public Sales(int _id, string _name, decimal _wageperhour, int _loggedhours, int _salesvol) : base(_id, _name, _wageperhour, _loggedhours)
        {
            this.SalesVol = _salesvol;
        }

        private const decimal _commission = 1m;
        private int SalesVol { get; }
        private decimal CalculateCommision()
        {
            return SalesVol * _commission;
        }

        private decimal CalculateSalaryAfterCommission()
        {
            return base.CalculateSalary() + CalculateCommision();
        }
        public override string ToString()
        {
            return
                base.ToString() +
                $"Commission: ${Math.Round(_commission)}/piece\n" +
                $"Sold pieces: ${this.SalesVol}\n" +
                $"Salary After Commission: ${Math.Round(CalculateSalaryAfterCommission(), 2)}\n";
        }
    }
}
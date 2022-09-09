using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            var E = new Employee(1001, "Charles III", 10, 200);
            var M = new Manager(1002, "Elizabeth II", 20, 150);
            var S = new Sales(1003, "Ahmed Moussa", 8, 250, 100);
            var P = new Programmer(1004, "Ehap Azzazi", 30, 180, true);
            var MC = new Maintanence(1005, "W7W7", 11, 250);
            Console.Write(E.ToString());
            Console.Write(M.ToString());
            Console.Write(S.ToString());
            Console.Write(P.ToString());
            Console.Write(MC.ToString());
        }
    }
}

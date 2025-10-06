using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homwork10
{
    internal class Bank: IFinanceOperations
    {
        const double percent = 0.05;

        public bool CheckUserHistory()
        {
            Random random = new Random();
            bool checks = random.Next(2) == 1;
            Console.WriteLine(checks ? "Loan approved" : "Loan rejected");
            return checks;
        }

        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            double total = amountPerMonth * month;
            double interest = total * percent;
            double finalAmount = total + interest;

            return finalAmount;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork10
{
    internal class MicroFinance: IFinanceOperations
    {
        const int commision = 4;

        const double percent = 0.1;
        public bool CheckUserHistory()
        {
            Console.WriteLine("Loan Approved");
            return true;
        }

        public double CalculateLoanPercent(int month, double amountsPerMonth)
        {
            double total = month * amountsPerMonth;
            double interest = total * percent;
            double commisionFee = month * commision;
            double finalAmount = total + interest + commisionFee;

            return finalAmount;
        }
    }
}

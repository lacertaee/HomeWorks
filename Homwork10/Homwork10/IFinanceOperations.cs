using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homwork10
{
    internal interface IFinanceOperations
    {
        double CalculateLoanPercent(int month, double AmountPerMonth);

        bool CheckUserHistory();
    }
}

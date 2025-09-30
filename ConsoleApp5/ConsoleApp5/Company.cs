using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Company
    {
        string company;
        double percentage;

        public Company(string company)
        {
            this.company = company;
        }

        public double GetPercentage()
        {
            if (company == "adgilobrivi")
            {
                percentage = 0.18D;
            } else
            {
                percentage = 0.05D;
            }

            return percentage;
        }
    }
}

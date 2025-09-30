using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Employee
    {
        string name, surname, position;
        int age;
        List<int> workingHours;

        public Employee(string name, string surname, string position, int age, List<int> workingHours)
        {
            this.name = name;
            this.surname = surname;
            this.position = position;
            this.age = age;
            this.workingHours = workingHours;
        }

        public double GetWeeklySalary()
        {
            int hourlyPay = GetHourlyPay(position);
            int overtime = 5;

            double salary = 0;

            for (int i = 0; i < workingHours.Count; i++)
            {
                if (workingHours[i] > 8)
                {
                    salary += (workingHours[i] - 8) * overtime;
                }
                if (i >= 5)
                {
                    salary += workingHours[i] * hourlyPay * 2;
                }
                else
                {
                    salary += workingHours[i] * hourlyPay;
                }
                    
            }
            if (workingHours.Sum() > 50)
            {
                salary += salary * 0.2D;
            }

            return salary;
        }


        int GetHourlyPay(string position)
        {
            switch (position.ToLower())
            {
                case "manager":
                    return 40;
                case "developer":
                    return 30;
                case "tester":
                    return 20;
                default: return 10;
            }
        }
    }
}

using System;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First
            Console.Write("size of array: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            var arr1 = new List<int>();
            var evens = new List<int>();
            var odds = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                arr1.Add(i);
            }

            foreach (int i in arr1)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            Console.Write("მასივი#1: ");
            foreach (int i in evens)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.Write("მასივი#1: ");
            foreach (int i in odds)
            {
                Console.Write(i + " ");
            }
            #endregion

            #region Second

            var contacts = new Dictionary<string, int>
            {
                {"luka", 591627784 }
            };

            contacts["dato"] = 551234458;

            foreach (var (key, value) in contacts)
            {
                Console.WriteLine($"number of {key} is: {value}");
            }

            Console.WriteLine();

            contacts["luka"] = 599873456;
            foreach (var (key, value) in contacts)
            {
                Console.WriteLine($"number of {key} is: {value}");
            }
            Console.WriteLine();


            contacts.Remove("luka");

            foreach (var (key, value) in contacts)
            {
                Console.WriteLine($"number of {key} is: {value}");
            }
            #endregion

            #region Third
            var nums = new List<int>();

            Console.Write("Array: ");

            string input = Console.ReadLine();

            string numbers = input.Replace(" ", "");

            foreach (char i in numbers)
            {
                nums.Add(int.Parse(i.ToString()));
            }

            var unique = new List<int>();

            int[] uniqueNumbers = nums.Distinct().ToArray();

            foreach (int i in uniqueNumbers)
            {
                var times = nums.Count(x => x == i);
                Console.WriteLine($"{i} appears {times} times sum {i * times}");
            }
            #endregion

            #region Fourth
            Console.Write("top: ");

            var scores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int top = int.Parse(Console.ReadLine());

            var answer = scores.OrderByDescending(x => x).Take(top).OrderBy(x => x);

            foreach (var item in answer)
            {
                Console.Write(item + " ");
            }
            #endregion



        }
    }
}

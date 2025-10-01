using System;
using System.Linq;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1

            //Console.WriteLine(First(2, 27, 4));

            //2

            //Console.WriteLine(Second("AAABB"));

            //3

            //Console.WriteLine(Third("Some Random Text", "It is Some Random Text"));

            //4

            //var list = new List<bool> { true, false, false, true, true, false};
            //Fourth(list);

            //5

            //Fifth(12345);

            //6

            //Console.WriteLine(Sixth([1, 2, 3, 1]));
        }

        public static int First(int a, int b, int n)
        {
            int answer = 0;
            for (int i = 1; ; i++)
            {
                double power = Math.Pow(i, n);
                if (power > b)
                {
                    break;
                }
                if (a <= power && power <= b)
                {
                    answer++;
                }
            }

            return answer;
        }

        public static int Second(string str)
        {
            return str.GroupBy(x => x).Sum(x => x.Count() / 2);
        }

        public static string Third(string first, string second)
        {
            first = new string(first.Reverse().ToArray());
            second = new string(second.Reverse().ToArray());

            string answer = "";

            string iterable = first.Length > second.Length ? second : first;

          


            for (int i = 0; i < iterable.Length ; i++)
            {
                if (first[i] != second[i])
                {
                    break;
                }

                answer += first[i];
            }

            return new string(answer.Reverse().ToArray());
        }

        public static void Fourth<T>(List<T> param)
        {
            if (typeof(T) == typeof(string))
            {
                foreach (var item in param.Cast<string>())
                {
                    Console.WriteLine(item.ToUpper());
                }
            } else if (typeof(T) == typeof(int))
            {
                Console.WriteLine(param.Cast<int>().Sum());
            } else if (typeof(T) == typeof(bool))
            {

                Console.WriteLine($"{param[0]} {param[param.Count / 2]} {param[param.Count-1]}");
            }
        }

        public static void Fifth(int num)
        {
            if (num < 10)
            {
                Console.Write(num);
                return;
            }

            Fifth(num / 10);

            Console.Write(" - " + (num % 10));
        }
           
        public static bool Sixth<T>(T[] arr)
        {
            return arr.GroupBy(x => x).Any(x => x.Count() > 1);
        }
    }

    
}

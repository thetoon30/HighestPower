using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestPower
{
    class Program
    {
        static void Main(string[] args)
        {
            //The input range is from 1 to 1,000,000. 
            int n = 90;
            Console.WriteLine(n + " " + HighestPower(n));
            n = 65;
            Console.WriteLine(n + " " + HighestPower(n));
            n = 81;
            Console.WriteLine(n + " " + HighestPower(n));
            n = 29;
            Console.WriteLine(n + " " + HighestPower(n));
            n = 6;
            Console.WriteLine(n + " " + HighestPower(n));
            Console.ReadKey();
        }

        private static Tuple<int, int> HighestPower(int n)
        {
            if (n <= 4 && n != 1)
            {
                return new Tuple<int, int>(1, -1);
            }
            else if (n == 1)
            {
                return new Tuple<int, int>(0, -1);
            }

            int output = 0;
            int count = 0;
            List<double> numbers = new List<double>();
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    var op = Math.Pow(j, i);
                    if (op >= n)
                    {
                        break;
                    }

                    var g = numbers.FirstOrDefault(x => x == op);
                    if (g == 0)
                    {
                        numbers.Add(op);
                    }
                }
            }

            output = (int)numbers.Max();
            count = Occurrences(output);

            return new Tuple<int, int>(output, count);
        }

        private static int Occurrences(int n)
        {
            int val = 0;

            for (int i = 2; i < n; i++)
            {
                double logarithm = Math.Log(n) / Math.Log(i);
                double f = logarithm % 1;
                if (f == 0)
                {
                    val++;
                }
            }

            return val;
        }
    }
}

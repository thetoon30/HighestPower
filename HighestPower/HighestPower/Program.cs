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

        private static int HighestPower(int n)
        {
            int i = 0;
            n = n - 1;
            for (i = n; i >= 1; i--)
            {
                if ((int)Math.Sqrt(i) * (int)Math.Sqrt(i) == i)
                {
                    break;
                }
            }

            return i;
        }
    }
}

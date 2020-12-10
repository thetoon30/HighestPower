using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestPower
{
    public class HighestPowerOccurrences
    {
        public static Tuple<int, int> Calculate(int n)
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
            double root = Math.Sqrt(n);

            for (int i = 2; i <= root; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    double op = Math.Pow(j, i);
                    if (op >= n)
                    {
                        break;
                    }

                    if (op > output)
                    {
                        output = (int)op;
                        count = 0;
                    }

                    if (op == output)
                    {
                        count++;
                    };
                }
            }

            return new Tuple<int, int>(output, count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise6
{
    public class Solution
    {
        public double x;
        public double y;
        public double b;
        public double a;
        public Solution(double x, double y, double b, double a)
        {
            this.x = x;
            this.y = y;
            this.b = b;
            this.a = a;
        }
        public double Calculate(double x, double y, double b, double a)
        {
            double sum = 0;
            for (int i = 1; i <= 30; i++)
            {
                sum += ((-1) ^ i) * Math.Pow((Math.Tan(x) + Math.Cos(a) - Math.Tan(b)), y) / Factorial(i) * x;
            }
            return sum;
        }
        public double Factorial(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return n * Factorial(n - 1);
            }
            else
            {
                throw new ArgumentException("Number must be non-negative");
            }
        }

        public static int ModInv(long a, int n)
        {
            long b0 = n, t, q;
            long x0 = 0, x1 = 1;

            if (n == 1) return 1;

            while (a > 1)
            {
                q = a / n;
                t = n;
                n = (int)(a % n);
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += b0;

            return (int)x1;
        }

        public static int ICG(int n, int a, int c, long seed)
        {
            if (n == 0)
            {
                if (seed % (n + 1) == 0)
                {
                    seed++;
                }
                if (seed == 0)
                {
                    throw new ArgumentException("Seed cannot be zero");
                }
                return (a * ModInv(seed, n + 1) + c) % n;
            }
            else
            {
                if (seed % n == 0)
                {
                    seed++;
                }
                if (seed == 0)
                {
                    throw new ArgumentException("Seed cannot be zero");
                }
                return (a * ModInv(seed, n) + c) % n;
            }
        }
    }
}


using System;

namespace lab_9
{
    public static class MathFunctions
    {
        public static double Result(double a, double b, double c, double x)
        {
            if (a < 0 && x != 0)
            {
                return a * Math.Pow(x, 2) + Math.Pow(b, 2) * x;
            }
            else if (a > 0 && x == 0)
            {
                return x - a / (x - c);
            }
            else
            {
                return 1 + x / c;
            }
        }
    }
}

using System;

namespace Calculations
{
    public class Power
    {
        public int Pow(int a, int b)
        {
            if (a < 0 ) throw new ArgumentOutOfRangeException("a");
            if (b < 0 ) throw new ArgumentOutOfRangeException("b");
            var power = 1;
            for (int i = 0; i < b ; i++)
            {
                power = power * a;
            }
            return power;
        }
    }
}

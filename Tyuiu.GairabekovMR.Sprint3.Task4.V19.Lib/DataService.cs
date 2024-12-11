using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 0;
            for (int x = startValue; x >= stopValue; x--)
            {
                result += Math.Pow(x, 2) / Math.Sin(x);
            }
            return Math.Round(result, 3);
        }

        public double GetSumSumSeries(int a, int b, int c, int d, int x)
        {
            double result = 0;
            for (int i = a; i <= b; i++)
            {
                for (int k = c; k <= d; k++)
                {
                    result += (Math.Sin(k) + x) / (double)x;
                }
            }
            return Math.Round(result, 3);
        }
    }
}


using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double GetSumSumSeries(int a, int b, int c, int d, int x)
        {
            double result = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    result += Math.Sin(k) + 1.0;
                }
            }

            return Math.Round(result, 3);
        }

        public double Calculate(int startValue, int stopValue)
        {
            return 0;
        }
    }
}



using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double GetSumSumSeries(int a, int b, int c, int d, int x)
        {
            double sumSeries = 0;

            // Ensure correct order of arguments for the loop
            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                for (int k = Math.Min(c, d); k <= Math.Max(c, d); k++)
                {
                    sumSeries += (Math.Sin(k) + x) / x;
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}




using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double GetSumSumSeries(int a, int b, int c, int d, int x)
        {
            double sumSeries = 0;

            for (int i = a; i <= b; i++)
            {
                for (int k = c; k <= d; k++)
                {
                    sumSeries += (Math.Sin(k) + x) / x;
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}




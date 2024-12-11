using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib
{
    
    
    public class DataService : ISprint3Task4V19
    {
        public double Calculate(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }

        public double GetSumSumSeries(int a, int b, int c, int d, int x)
        {
            double y = 0;

            for (int i = a; i <= b; i++)
            {
                for (int k = c; k <= d; k++)
                {
                    y += (Math.Sin(k) + x) / x;
                }
            }

            return Math.Round(y, 3);
        }
    }
}



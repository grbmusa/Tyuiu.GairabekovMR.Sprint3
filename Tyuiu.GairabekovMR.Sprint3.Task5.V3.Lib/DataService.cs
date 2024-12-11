using System;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib
{
    public class DataService
    {
        public double CalculateY(double x)
        {
            double y = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    y += (Math.Sin(k) + x) / x;
                }
            }

            return Math.Round(y, 3);
        }
    }
}


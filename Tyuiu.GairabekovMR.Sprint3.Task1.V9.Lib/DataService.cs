using System;

namespace Tyuiu.GairabekovMR.Sprint3.Task1.V9.Lib
{
    public class DataService
    {
        public double CalculateProduct(int x)
        {
            double p = 1;
            int k = 1;

            while (k <= 4)
            {
                p *= Math.Pow(300 / (Math.Cos(x) + Math.Pow(x, k)), k);
                k++;
            }

            return Math.Round(p, 3);
        }
    }
}


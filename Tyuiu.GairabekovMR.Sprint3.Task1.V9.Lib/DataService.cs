using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        

        public double GetMultiplySeries(int x, int start, int stop)
        {
            double p = 1;

            for (int k = start; k <= stop; k++)
            {
                double denominator = Math.Cos(x) + Math.Pow(x, k);
                double term = Math.Pow(300.0 / denominator, k);
                p *= term;
            }

            return Math.Round(p, 3);
        }
    }
}


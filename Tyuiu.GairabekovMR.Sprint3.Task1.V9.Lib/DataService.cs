using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double CalculateProduct(int x)
        {
            double p = 1;
            int k = 1;

            while (k <= 4)
            {
                // Исправление формулы
                p *= Math.Pow(300.0 / (Math.Cos(x) + Math.Pow(x, k)), k);
                k++;
            }

            return Math.Round(p, 3);
        }

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}


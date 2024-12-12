using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];
            int i = 0;

            for (int j = startValue; j <= stopValue; j++)
            {
                if ((Math.Cos(j) + j) == 0)
                {
                    a[i] = 0.0;
                    i++;
                }
                else
                {
                    a[i] = Math.Round(((2 * j - 3) / (Math.Cos(j) + j)) + 5, 2);
                    i++;
                }
            }

            return a;
        }
    }
}
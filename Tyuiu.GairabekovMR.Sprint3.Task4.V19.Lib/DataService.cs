using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task4.V19.Lib
{
    public class DataService : ISprint3Task4V19
    {
        public DataService()
        {
        }

        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res * (x / (Math.Cos(x) + x) + 0.5);
                }
            }
            return Math.Round(res, 3);
        }
    }
}

//res = res * ((x / Math.Cos(x) + x) + 0.5);
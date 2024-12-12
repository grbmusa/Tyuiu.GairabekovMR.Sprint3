using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GairabekovMR.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0)
                    {
                        if (d > 10)
                        {
                            sum++;
                        }
                    }
                }
            }
            return sum;
        }
    }
}

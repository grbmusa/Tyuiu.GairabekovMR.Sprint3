namespace Sprint3.TaskReview.V9.Lib;

public class FunctionCalculator
{
    public double[] CalculateFunctionValues(int start, int end, int step)
    {
        int size = (end - start) / step + 1; // размерность 
        double[] values = new double[size]; // инициализация 

        for (int i = 0, x = start; x <= end; x += step, i++)
        {
            double denominator = Math.Cos(x) - 2 * x; // знаменатель 1-ой дроби
            double fx;

            if (denominator == 0) // проверка деления на 0
            {
                fx = 0;
            }
            else
            {
                fx = (2 * x - 3) / denominator + 5 * x - Math.Sin(x);
                fx = Math.Round(fx, 2); // округление
            }

            values[i] = fx; // запись в массив
        }
        return values;
    }
}

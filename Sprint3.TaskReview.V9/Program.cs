using Sprint3.TaskReview.V9.Lib;

int start = -5;
int end = 5;
int step = 1;

FunctionCalculator calculator = new FunctionCalculator();

double[] values = calculator.CalculateFunctionValues(start, end, step);

Console.WriteLine("Таблица значений функции:");
Console.WriteLine(" x\tF(x)");

for (int i = 0, x = start; x <= end; x += step, i++)
{
    Console.WriteLine($" {x}\t{values[i]}");
}
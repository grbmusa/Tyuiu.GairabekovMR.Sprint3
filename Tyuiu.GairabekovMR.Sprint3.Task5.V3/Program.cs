using Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл for                                                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение y по формуле, при x=5    *");
            Console.WriteLine("***************************************************************************");

            double x = 5;
            double result = ds.CalculateY(x);

            Console.WriteLine("Результат: " + result);
        }
    }
}


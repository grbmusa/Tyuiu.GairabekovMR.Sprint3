using Tyuiu.GairabekovMR.Sprint3.Task1.V9.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл while                                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет произведение ряда по формуле, при *");
            Console.WriteLine("* x=5                                                                     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат: " + ds.CalculateProduct(5));
        }
    }
}


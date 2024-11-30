namespace Tyuiu.GairabekovMR.Sprint3.Task2.V5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new();
            Console.Title = "Спринт #3 | Выполнил: Гайрабеков М.Р. | ИИПб 24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Оператор цикла do-while                                                 ");
            Console.WriteLine("* Задание #2                                                               ");
            Console.WriteLine("* Вариант #5                                                               ");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб 24-2                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму    ");
            Console.WriteLine("* ряда по формуле, при a=0,75                                              ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("* Введите значние х:                                                       ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние y:                                                       ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значение z:                                                      ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSeries(z, x, y));
            Console.ReadKey();
        }
    }

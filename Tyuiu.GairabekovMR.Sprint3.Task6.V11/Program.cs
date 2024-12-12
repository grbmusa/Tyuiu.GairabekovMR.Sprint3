using Tyuiu.GairabekovMR.Sprint3.Task6.V11.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 10;
            int y = 19;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumTheDivisors(x, y));
            Console.ReadKey();
        }
    }
}
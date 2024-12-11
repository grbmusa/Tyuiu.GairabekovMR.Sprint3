using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeries_Valid()
        {
            DataService ds = new DataService();
            int a = 1;
            int b = 3;
            int c = 1;
            int d = 11;
            int x = 5;

            double expected = 33.247; 
            double actual = ds.GetSumSumSeries(a, b, c, d, x);
            Assert.AreEqual(expected, actual);
        }

        private double CalculateExpectedSum(int a, int b, int c, int d, int x)
        {
            double y = 0;

            for (int i = a; i <= b; i++)
            {
                for (int k = c; k <= d; k++)
                {
                    y += (Math.Sin(k) + x) / x;
                }
            }

            return Math.Round(y, 3);
        }
    }
}




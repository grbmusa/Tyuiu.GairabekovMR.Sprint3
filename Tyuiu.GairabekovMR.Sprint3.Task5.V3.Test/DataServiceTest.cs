using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GairabekovMR.Sprint3.Task5.V3.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateY_Valid()
        {
            DataService ds = new DataService();
            double x = 5;
            double expected = CalculateExpectedY(x);
            double actual = ds.CalculateY(x);
            Assert.AreEqual(expected, actual);
        }

        private double CalculateExpectedY(double x)
        {
            double y = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    y += (Math.Sin(k) + x) / x;
                }
            }

            return Math.Round(y, 3);
        }
    }
}


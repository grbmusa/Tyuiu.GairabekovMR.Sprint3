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
            int a = 5;
            int b = 1;
            int c = 1;
            int d = 3;
            int x = 11;

            double expected = 33.247;
            double actual = ds.GetSumSumSeries(a, b, c, d, x);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}




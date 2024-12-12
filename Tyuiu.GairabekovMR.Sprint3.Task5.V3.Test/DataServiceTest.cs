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

            double expected = 33.247;
            double actual = ds.GetSumSumSeries(5, 1, 1, 3, 11);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}




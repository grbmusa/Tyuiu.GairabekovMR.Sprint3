using NUnit.Framework;
using Tyuiu.GairabekovMR.Sprint3.Task2.V5.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.That(dataService.GetSumSeries(0.75, 1, 20), Is.EqualTo(0.333));
        }
    }
}
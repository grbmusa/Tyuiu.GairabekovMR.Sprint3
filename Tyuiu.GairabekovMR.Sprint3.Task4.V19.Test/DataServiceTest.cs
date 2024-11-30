using Tyuiu.GairabekovMR.Sprint3.Task4.V19.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 9.432;
            Assert.AreEqual(wait, res);
        }
    }
}
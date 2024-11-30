using Tyuiu.GairabekovMR.Sprint3.Task1.V9.Lib;

namespace Tyuiu.GairabekovMR.Sprint3.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateProduct_Valid()
        {
            DataService ds = new DataService();
            double expected = 5815.752; // ��������� ��������
            double actual = ds.CalculateProduct(5);
            Assert.That(actual, Is.EqualTo(expected).Within(0.001));
        }
    }
}
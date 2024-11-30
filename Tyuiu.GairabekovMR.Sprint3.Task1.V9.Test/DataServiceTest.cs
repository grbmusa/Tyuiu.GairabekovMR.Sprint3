namespace Tyuiu.GairabekovMR.Sprint3.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateProduct_Valid()
        {
            DataService ds = new DataService();
            double expected = 4.261; // Ожидаемое значение, полученное после выполнения расчета
            double actual = ds.CalculateProduct(5);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

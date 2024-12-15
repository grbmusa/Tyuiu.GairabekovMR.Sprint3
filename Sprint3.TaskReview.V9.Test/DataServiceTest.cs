
using Sprint3.TaskReview.V9.Lib;

namespace Sprint3.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateFunctionValues_HandlesDivisionByZero()
        {
            //Arrange
            FunctionCalculator calculator = new FunctionCalculator();
            int start = -1;
            int end = 1;
            int step = 1;

            //Act
            double[] actualValues = calculator.CalculateFunctionValues(start, end, step);

            //Assert
            Assert.IsFalse(actualValues[0] == 0 ? true : false); // проверка на 0
        }
    }
}
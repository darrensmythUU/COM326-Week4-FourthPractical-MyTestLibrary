using FourthPractical_MyTestLibrary;

namespace MyCalculatorTests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = double.MaxValue;
            double b = 20;

            // Act
            double result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(1.7976931348623157E+308, result);
        }

        [TestMethod]
        public void Add_LargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = double.MaxValue;
            double b = 10;

            // Act
            double result = calculator.Add(a, b);
            double expected = a + b;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 20;
            double b = 10;

            // Act
            double result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Subtract_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = -20;
            double b = -10;

            // Act
            double result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 5;

            // Act
            double result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Multiply_MixedSignNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = -10;
            double b = 5;

            // Act
            double result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_ThrowsExceptionIf0PassedAsParamenter()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 0;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => calculator.Divide(a, b));
        }

        [TestMethod]
        public void Divide_SmallNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = double.MinValue;
            double b = 5;

            // Act
            double result = calculator.Divide(a, b);
            double expected = a / b;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

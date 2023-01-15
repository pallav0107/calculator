using CalculatorTest;
using CalculatorTest.Diagnostics;
using Moq;

namespace CalculatorTestProject
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        IDiagnostics diagnostics;
        public SimpleCalculatorTest()
        {
            diagnostics= new ConsoleDiagnostics();
        }

        [TestMethod]
        public void Add_CallsDiagnosticsWithExpectedResult()
        {
            // Arrange
            var expectedResult = "3";
            var mockDiagnostics = new Mock<IDiagnostics>();
            var calculator = new SimpleCalculator(mockDiagnostics.Object);

            // Act
            calculator.Add(1, 2);

            // Assert
            mockDiagnostics.Verify(x => x.LogResult(expectedResult), Times.Once);
        }

        [TestMethod]
        public void Subtract_CallsDiagnosticsWithExpectedResult()
        {
            // Arrange
            var expectedResult = "-1";
            var mockDiagnostics = new Mock<IDiagnostics>();
            var calculator = new SimpleCalculator(mockDiagnostics.Object);

            // Act
            calculator.Subtract(1, 2);

            // Assert
            mockDiagnostics.Verify(x => x.LogResult(expectedResult), Times.Once);
        }

        [TestMethod]
        public void Add_Should_Return_Correct_Result()
        {
            // Arrange
            var calculator = new SimpleCalculator(diagnostics);
            int start = 60;
            int amount = 30;
            int expectedResult = 90;

            // Act
            int result = calculator.Add(start, amount);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Subtract_Should_Return_Correct_Result()
        {
            // Arrange
            var calculator = new SimpleCalculator(diagnostics);
            int start = 60;
            int amount = 30;
            int expectedResult = 30;

            // Act
            int result = calculator.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Multiply_Should_Return_Correct_Result()
        {
            // Arrange
            var calculator = new SimpleCalculator(diagnostics);
            int start = 60;
            int amount = 30;
            int expectedResult = 1800;

            // Act
            int result = calculator.Multiply(start, amount);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Divide_Should_Return_Correct_Result()
        {
            // Arrange
            var calculator = new SimpleCalculator(diagnostics);
            int start = 60;
            int amount = 30;
            int expectedResult = 2;

            // Act
            int result = calculator.Divide(start, amount);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
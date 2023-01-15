using CalculatorTest.Diagnostics;

namespace CalculatorTestProject
{
    [TestClass]
    public class ConsoleDiagnosticsTests
    {
        [TestMethod]
        public void LogResult_WritesResultToConsole()
        {
            // Arrange
            var consoleDiagnostics = new ConsoleDiagnostics();
            var expectedResult = "5";

            // Redirect console output to a StringWriter
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            consoleDiagnostics.LogResult(expectedResult);

            // Assert
            var actualResult = stringWriter.ToString().Trim();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

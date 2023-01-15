// Implement the diagnostics interface and inject it into the calculator at runtime.

namespace CalculatorTest.Diagnostics
{
    public class DummyDiagnostics : IDiagnostics
    {
        public void ReportError(string errorMessage)
        {
            // Do nothing
        }

        public void ReportWarning(string warningMessage)
        {
            // Do nothing
        }

        public void ReportInfo(string infoMessage)
        {
            // Do nothing
        }

        public void LogResult(string result)
        {
            throw new NotImplementedException();
        }
    }
}

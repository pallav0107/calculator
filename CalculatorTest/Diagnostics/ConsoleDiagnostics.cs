using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Diagnostics
{
    public class ConsoleDiagnostics : IDiagnostics
    {
        public void LogResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}

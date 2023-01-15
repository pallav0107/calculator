using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Diagnostics
{
    public interface IDiagnostics
    {
        void LogResult(string result);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTest.Diagnostics;

namespace CalculatorTest
{
    public class SimpleCalculator : ConsoleDiagnostics, ISimpleCalculator
    {
        private IDiagnostics _diagnostics;
        public SimpleCalculator(IDiagnostics diagnostics)
        {
            _diagnostics = diagnostics;
        }
        public int Add(int start, int amount)
        {
            int result = start + amount;
            _diagnostics.LogResult(result.ToString());
            return result;
        }

        public int Subtract(int start, int amount)
        {
            int result = start - amount;
            _diagnostics.LogResult(result.ToString());
            return result;
        }

        public int Multiply(int start, int by)
        { 
            int result = start * by;
            _diagnostics.LogResult(result.ToString());
            return result;
        }

        public int Divide(int start, int by)
        {
            int result;
            if (by == 0)
            {
                result = int.MaxValue;
            }
            else
            {
                result = start / by;
            }
            _diagnostics.LogResult(result.ToString());
            return result;
        }
    }
}

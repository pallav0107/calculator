using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Diagnostics
{
    public class DatabaseDiagnostics : IDiagnostics
    {
        private readonly CalculatorDbContext _dbContext;

        public DatabaseDiagnostics(CalculatorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void LogResult(string result)
        {
            var diagnostic = new Models.Diagnostics { Id = Guid.NewGuid(), Message = result, Timestamp = DateTime.Now };
            _dbContext.Diagnostics.Add(diagnostic);
            _dbContext.SaveChanges();
        }
    }
}

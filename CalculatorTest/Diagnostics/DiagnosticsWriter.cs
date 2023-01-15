using System.Data;
using System.Data.SqlClient;

namespace CalculatorTest.Diagnostics
{
    public class DiagnosticsWriter
    {
        private readonly string _connectionString;

        public DiagnosticsWriter(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void WriteDiagnostics(Models.Diagnostics diagnostics)
        {
            if (diagnostics is null)
            {
                throw new ArgumentNullException(nameof(diagnostics));
            }

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("InsertDiagnostics", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", diagnostics.Id);
                    command.Parameters.AddWithValue("@Message", diagnostics.Message);
                    command.Parameters.AddWithValue("@Timestamp", diagnostics.Timestamp);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}

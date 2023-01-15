using CalculatorApi.Controllers;
using CalculatorTest;
using CalculatorTest.Diagnostics;

namespace CalculatorApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
 
            builder.Services.AddTransient<IDiagnostics, ConsoleDiagnostics>();
            builder.Services.AddTransient<ISimpleCalculator, SimpleCalculator>();
            var app = builder.Build();


            app.MapControllers();

            app.Run();
        }
    }
}
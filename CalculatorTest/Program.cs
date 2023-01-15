using CalculatorTest;
using CalculatorTest.Diagnostics;

// Implement the diagnostics interface and inject it into the calculator at runtime.
IDiagnostics diagnostics = new ConsoleDiagnostics();
var calculator = new SimpleCalculator(diagnostics);
int result = calculator.Add(1, 2);
Console.WriteLine("Result: " + result);


int addResult = calculator.Add(2, 3);
Console.WriteLine("Add Result: " + addResult);

int subtractResult = calculator.Subtract(2, 3);
Console.WriteLine("Subtract Result: " + subtractResult);

int multiplyResult = calculator.Multiply(2, 3);
Console.WriteLine("Multiply Result: " + multiplyResult);

int divideResult = calculator.Divide(2, 3);
Console.WriteLine("Divide Result: " + divideResult);

using (var context = new DiagnosticsContext())
{
 
    context.Diagnostics.Add(new CalculatorTest.Models.Diagnostics
    {
        Id= Guid.NewGuid(),
        Message = "This is an error message.",
        Timestamp = DateTime.Now,

    });
    context.SaveChanges();
}


DiagnosticsWriter wr = new DiagnosticsWriter(Constants.ConnectionString);
wr.WriteDiagnostics(new CalculatorTest.Models.Diagnostics() {
    Id = Guid.NewGuid(),
    Message = "This ado .net message.",
    Timestamp = DateTime.Now,
});

Console.ReadKey();

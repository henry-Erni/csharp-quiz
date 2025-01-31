namespace CalculatorApp;

class Program
{
    static void Main(string[] args)

    {
        double num1 = 0;
        double num2 = 0;
        string operation = "add";
        bool validInput = false;

        try
        {
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            operation = Console.ReadLine()?.ToLower() ?? string.Empty;

            validInput = true;

            if (validInput)
            {
                var calculator = new Calculator();
                double result = calculator.PerformOperation(num1, num2, operation);
                Console.WriteLine($"The result is: {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input. Please enter a number");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (InvalidOperationException e)  
        {
            Console.WriteLine("An error occurrred: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Calculation attempt finished.");
        }
    }
}
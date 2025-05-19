using System.Globalization;

namespace CS_Basic;

class Program
{
    static void Main(string[] args)
    {
        //Person person = new Person("John Doe", 30, DateTime.Parse("22.02.1990"), ["Programming", "Gaming", "Ethical hacking"]);
        //person.Greeting();

        Calculator calculator = new Calculator();

        Console.WriteLine("Choose a operator: (+,-,*,/,^, square-root)");

        string? _operator = Console.ReadLine();

        Console.WriteLine("First number:");

        string? inputA = Console.ReadLine();

        Console.WriteLine("Second number:");

        string? inputB = Console.ReadLine();

        if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
        {
            double result = 0;

            switch (_operator)
            {
                case "+":
                    result = calculator.Add(a, b);
                    break;
                case "-":
                    result = calculator.Subtract(a, b);
                    break;
                case "*":
                    result = calculator.Multiply(a, b);
                    break;
                case "/":
                    result = calculator.Divide(a, b);
                    break;
                case "^":
                    result = calculator.Power(a, b);
                    break;
                case "square-root":
                    result = calculator.SquareRoot(a);
                    break;
                default:
                    Console.WriteLine("Invalid operator selected!");
                    break;
            }
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
}

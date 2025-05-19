public interface ICalculator
{
    /// <summary>
    /// A method that adds two numbers together
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>the sum of a + b</returns>
    double Add(double a, double b);
    /// <summary>
    /// A method that subtracts a number (b) from (a)
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>the sum of a - b</returns>
    double Subtract(double a, double b);
    /// <summary>
    /// A method that multiplies a number (a) with (b)
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>the sum of a * b</returns>
    double Multiply(double a, double b);
    /// <summary>
    /// A method that divides a number (a) with (b) when b is greater than 0
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns>the sum of a / b when b > 0</returns>
    double Divide(double a, double b);
    /// <summary>
    /// A method that returns the power of a number (a)
    /// </summary>
    /// <param name="a">base</param>
    /// <param name="exponent">exponent (e) > 1</param>
    /// <returns></returns>
    double Power(double a, double exponent);
    /// <summary>
    /// A method that returns the square root of any natural number
    /// </summary>
    /// <param name="a">base</param>
    /// <returns>the square root of (a)</returns>
    double SquareRoot(double a);
}
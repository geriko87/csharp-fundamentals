namespace _03_ExpressionCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the expression to be calculated: ");
            string expression = Console.ReadLine();

            string[] parts = expression.Split(' ');

            int number1 = int.Parse(parts[0]);
            int number2 = int.Parse(parts[2]);

            if (parts[1] == "+") 
            {
                int addition = number1 + number2;
                Console.WriteLine($"Result: {addition}");
            }
            else if (parts[1] == "-")
            {
                int subtraction = number1 - number2;
                Console.WriteLine($"Result: {subtraction}");
            }
            else if (parts[1] == "*")
            {
                int multiplication = number1 * number2;
                Console.WriteLine($"Result: {multiplication}");
            }
            else if (parts[1] == "/")
            {
                if (parts[2] == "0")
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    double division = (double)number1 / number2;
                    Console.WriteLine($"Result: {division}");
                }
            }
            else
            {
                Console.WriteLine("Invalid expression.");
            }
        }
    }
}

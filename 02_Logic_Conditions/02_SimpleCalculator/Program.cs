namespace _02_SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int anotherNumber = int.Parse(Console.ReadLine());

            Console.Write("Specify an operation(+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            if (operation == '+') 
            {
                int addition = number + anotherNumber;
                Console.WriteLine($"{number} + {anotherNumber} = {addition}");
            }
            else if(operation == '-')
            {
                int subtraction = number - anotherNumber;
                Console.WriteLine($"{number} - {anotherNumber} = {subtraction}");
            }
            else if (operation == '*')
            {
                int multiplication = number * anotherNumber;
                Console.WriteLine($"{number} * {anotherNumber} = {multiplication}");
            }
            else if (operation == '/')
            {
                if (anotherNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    double division = (double)number / anotherNumber;
                    Console.WriteLine($"{number} / {anotherNumber} = {division}");
                }
            }
            else 
            {
                Console.WriteLine("Invalid operation.");
            }
        }
    }
}

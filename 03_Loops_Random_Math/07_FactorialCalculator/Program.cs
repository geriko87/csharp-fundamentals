namespace _07_FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer and I will calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = number;

            Console.Write($"{number}! = {number} ");

            for (int i = number - 1; i > 0; i--) 
            {
                factorial *= i;
                Console.Write($"* {i} ");
            }
            Console.Write($"= {factorial}");
        }
    }
}

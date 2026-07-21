namespace _01_PrintNumbersAndEvens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write($"Numbers between 0 and {number}: ");
            for (int i = 0; i <= number; i++) 
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write($"Even numbers between 0 and {number}: ");
            for (int i = 0; i <= number; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}

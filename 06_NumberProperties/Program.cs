namespace _06_NumberProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (number % 2 == 0)
            {
                Console.WriteLine($"The {number} is even.");
            }
            else 
            {
                Console.WriteLine($"The {number} is odd.");
            }
            Console.WriteLine();

            int counter = 0;
            for (int i = 2; i < number; i++) 
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Positive divisors of the {number} is {counter}.");
            Console.WriteLine();

            if (number <= 1) 
            {
                Console.WriteLine($"The {number} is neither prime nor composite.");
            }
            else if (counter > 0)
            {
                Console.WriteLine($"The {number} is a composite number.");
            }
            else
            {
                Console.WriteLine($"The {number} is a prime number.");
            }
        }
    }
}

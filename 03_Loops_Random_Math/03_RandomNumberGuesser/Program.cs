namespace _03_RandomNumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 1000: ");
            int number = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber;
            int attempts = 0;
            do
            {
                randomNumber = rnd.Next(1, 1001);
                Console.WriteLine(randomNumber);
                attempts++;

            } while (number != randomNumber);

            Console.WriteLine($"Number of attempts: {attempts}");
        }
    }
}

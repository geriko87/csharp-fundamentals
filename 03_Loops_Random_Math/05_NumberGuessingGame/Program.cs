namespace _05_NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int thoughtNumber = rnd.Next(1, 101);
            int tip;
            int attempts = 0;

            do
            {
                Console.Write("I thought of a number between 1 and 100, guess which one it is: ");
                tip = int.Parse(Console.ReadLine());
                attempts++;

                if (tip < thoughtNumber)
                {
                    Console.WriteLine("The number is bigger, try again.");
                }
                else if (tip > thoughtNumber)
                {
                    Console.WriteLine("The number is smaller, try again.");
                }
                else 
                {
                    Console.WriteLine($"Congratulations! Successful hit on the {attempts}. attempt!");
                }
                Console.WriteLine();

            } while (tip != thoughtNumber);
        }
    }
}

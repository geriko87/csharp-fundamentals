namespace _04_AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int currentYear = DateTime.Now.Year;
            int currentAge = currentYear - yearOfBirth;
            Console.WriteLine($"You are {currentAge} years old in {currentYear}.");
            Console.WriteLine($"You will be {currentAge + 1} next year.");
        }
    }
}

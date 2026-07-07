namespace _06_TimeFormatConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Specify a time in seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;

            Console.WriteLine($"Time in seconds: {seconds}");
            Console.WriteLine($"Formatted time: {minutes:D2}:{remainingSeconds:D2}");
        }
    }
}

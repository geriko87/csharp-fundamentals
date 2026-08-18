namespace _09_ConsoleTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Specify a time in seconds: ");
            int timeInSeconds = int.Parse(Console.ReadLine());

            for (int i = timeInSeconds; i >= 0; i--)
            {
                Console.Clear();

                int inMinutes = i / 60;
                int remainderSeconds = i % 60;

                if (i < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                }
                Console.WriteLine($"{inMinutes:D2}:{remainderSeconds:D2}");
                System.Threading.Thread.Sleep(1000);
            }
            Console.Beep(1000, 3000);
            Console.ResetColor();
        }
    }
}

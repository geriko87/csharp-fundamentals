namespace _02_ConsoleBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 02 - Console Basics
            
            Console.WindowHeight = 25;
            Console.WindowWidth = 100;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(10, 5);
            Console.CursorVisible = false; // Keep the cursor hidden for a cleaner console output.

            Console.WriteLine("Hello, World!");

            // Keep console open until Enter is pressed
            Console.ReadLine();

        }
    }
}

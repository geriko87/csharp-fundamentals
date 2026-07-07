namespace _03_UserInput_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello, {inputName}!");
        }
    }
}

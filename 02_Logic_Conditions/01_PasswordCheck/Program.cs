namespace _01_PasswordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter the password again: ");
            string passwordAgain = Console.ReadLine();
            Console.Clear();

            if (password == passwordAgain)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password accepted.");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect password.");
            }
            Console.ResetColor();
        }
    }
}

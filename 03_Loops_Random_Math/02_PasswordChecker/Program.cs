namespace _02_PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string savedPassword = "1234";
            string enteredPassword;
            int maxAttempts = 3;
            int attempts = 0;

            do
            {
                Console.Clear();
                Console.Write($"Enter the password (Attempts remaining: {maxAttempts - attempts}): ");
                enteredPassword = Console.ReadLine();

                attempts++;
            } while (savedPassword != enteredPassword && attempts < maxAttempts);

            Console.Clear();

            if (savedPassword == enteredPassword) 
            {
                Console.WriteLine("Access granted! Successful login!");
            }
            else 
            {
                Console.WriteLine("Access denied! No more attempts!");
            }
        }
    }
}

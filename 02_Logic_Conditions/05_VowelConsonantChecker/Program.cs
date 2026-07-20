namespace _05_VowelConsonantChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());

            string vowels = "aeiou";

            if (char.IsLetter(letter))
            {
                char lowerCaseLetter = char.ToLower(letter);

                if (vowels.Contains(lowerCaseLetter))
                {
                    Console.WriteLine("The given letter is a vowel.");
                }
                else
                {
                    Console.WriteLine("The given letter is a consonant.");
                }
            }
            else 
            {
                Console.WriteLine("Invalid letter.");
            }
        }
    }
}

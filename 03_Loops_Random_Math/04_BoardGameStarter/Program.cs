namespace _04_BoardGameStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of players: ");
            int numOfPlayers = int.Parse(Console.ReadLine());
            Console.Clear();

            Random rnd = new Random();
            int currentPlayer = 1;

            while (true) 
            {
                Console.WriteLine($"Player {currentPlayer}. press enter to roll!");
                Console.ReadLine();

                int roll = rnd.Next(1, 7);
                Console.WriteLine($"Roll: {roll} ");

                if (roll == 6)
                {
                    Console.WriteLine($"Congratulations! Player {currentPlayer}. can start the game!");
                    break;
                }
                Console.WriteLine($"No hit, next player can throw!");

                currentPlayer++;
                if(currentPlayer > numOfPlayers) 
                {
                    currentPlayer = 1;
                }
            }
        }
    }
}

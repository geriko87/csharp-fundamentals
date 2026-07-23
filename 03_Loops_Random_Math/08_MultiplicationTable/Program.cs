namespace _08_MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++) 
            {
                for (int j = 1; j <= 9; j ++) 
                {
                    if (i * j < 10)
                    {
                        Console.Write(" " + i * j + " ");
                    }
                    else 
                    {
                        Console.Write(i * j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

namespace _06_TankFillingSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the volume of the tank: ");
            double volume = double.Parse(Console.ReadLine());
            Console.Write("Enter the volume flow of the first channel: ");
            double canal1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the volume flow of the second channel: ");
            double canal2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the duration: ");
            double time = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double filledTank = (canal1 + canal2) * time;
            double tankOverfill = filledTank - volume;

            if (tankOverfill > 0)
            {
                Console.WriteLine($"The tank will be overfilled by {tankOverfill} m3.");
            }
            else 
            {
                double tankSaturation = (filledTank / volume) * 100;
                Console.WriteLine($"Volume = {volume}\nCanal1 = {canal1}\nCanal2 = {canal2}\nTime = {time}\n\nTankSaturation = {tankSaturation:F2}%");
            }
        }
    }
}

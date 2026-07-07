namespace _05_BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your body high in meter(e.g.: 1,72): ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Enter your body weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);
            Console.WriteLine($"Your BMI = {bodyMassIndex:F2}");
        }
    }
}

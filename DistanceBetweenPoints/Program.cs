namespace DistanceBetweenPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of y2: ");
            double y2 = double.Parse(Console.ReadLine());

            //calculate
            double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));

            Console.WriteLine($"Distance betwwen point 1  and point 2  is {distance:F2}");


            
        }
    }
}
namespace Exercise2Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;
            int num3 = 20;
            int num4 = 25;

            var sum = (num1 + num2+num3+num4);
            var avg = sum / 4.0;
            Console.WriteLine(Convert.ToDouble(avg));

        }
    }
}
namespace EvenOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even or Odd Checker");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsEven(number))
                Console.WriteLine($"{number} is even.");
            else
                Console.WriteLine($"{number} is odd.");
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
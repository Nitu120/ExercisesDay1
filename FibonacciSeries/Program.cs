namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series");

            Console.Write("Enter the number of terms: ");
            int numTerms = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < numTerms; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.WriteLine();
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int prev = 0;
            int current = 1;

            for (int i = 2; i <= n; i++)
            {
                int next = prev + current;
                prev = current;
                current = next;
            }

            return current;
        }
    }
}
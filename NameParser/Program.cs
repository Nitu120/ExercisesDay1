namespace NameParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            if(parts.Length == 0 )
            {
                Console.WriteLine("Provide name");
            }else if(parts.Length == 3)
            {
                Console.WriteLine($"First Name {parts[0]}");
                Console.WriteLine($"Middle Name {parts[1]}");
                Console.WriteLine($"Last Name {parts[2]}");
            }
            else if (parts.Length == 2)
            {
                Console.WriteLine($"First Name {parts[0]}");
                Console.WriteLine($"Middle Name undefined");
                Console.WriteLine($"Last Name {parts[1]}");

            }
            
            



        }
    }
}
namespace GegorianCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year to find if it is leap year: ");
            int year = int.Parse(Console.ReadLine());

            if(year % 4 ==0) 
            {
                if(year%100 == 0)
                {
                Console.WriteLine($"Year {year} is leap year.");
                
                }
                else
                {
                    Console.WriteLine($"Year {year} is not leap year");
                }

            }
            else
            {
                Console.WriteLine($"Year {year} is not leap year");
            }
        }
    }
}
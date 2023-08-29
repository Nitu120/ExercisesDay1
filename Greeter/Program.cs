namespace Greeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeOfDay = currentTime.TimeOfDay;
            string greeting;

            if (timeOfDay >= TimeSpan.FromHours(5) && timeOfDay < TimeSpan.FromHours(10))
            {
                greeting = "Good morning";
            }
            else if (timeOfDay >= TimeSpan.FromHours(10) && timeOfDay < TimeSpan.FromHours(18))
            {
                greeting = "Good day";
            }
            else if (timeOfDay >= TimeSpan.FromHours(18) && timeOfDay < TimeSpan.FromHours(24))
            {
                greeting = "Good evening";
            }
            else
            {
                greeting = "Welcome to late shift";
            }

            Console.WriteLine(greeting + "! The current time is " + currentTime.ToString("hh:mm tt"));

        }
    }
}
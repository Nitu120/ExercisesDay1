namespace TerminationDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the current date.
            DateTime currentDate = DateTime.Now;

            // Prompt the user for the insurance policy renewal date.
            Console.WriteLine("Enter the insurance policy renewal date:");
            string renewalDateString = Console.ReadLine();
            DateTime renewalDate = DateTime.Parse(renewalDateString);

            // Calculate the end of the 10-day grace period.
            DateTime gracePeriodEndDate = renewalDate.AddDays(10);

            // Calculate the date 1 month in the future.
            DateTime cancellationDate = renewalDate.AddMonths(1);

            // Display the two dates to the user.
            Console.WriteLine("The end of the 10-day grace period is: {0}", gracePeriodEndDate);
            Console.WriteLine("The policy can be cancelled due to lack of payment on: {0}", cancellationDate);
        }
    }
    }

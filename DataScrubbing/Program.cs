namespace DataScrubbing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter phone number");
                string phone = Console.ReadLine();
                string cleanPhone = ScrubPhone(phone);
                Console.WriteLine($"Your number is {cleanPhone}");

                string cleanPhone1 = ScrubPhone(phone,'-');
                Console.WriteLine($"Your number is {cleanPhone1}");

                string cleanPhone2 = ScrubPhone(phone,'-','.' );
                Console.WriteLine($"Your number is {cleanPhone2}");

            }
            
        }

       public static string ScrubPhone(string phoneNumber)
        {
            phoneNumber = phoneNumber.Trim();
            return phoneNumber;
            
        }

       public static string ScrubPhone( string phoneNumber, char charToRemove)
        {
            phoneNumber = phoneNumber.Replace(charToRemove,'\0').Trim();
            return phoneNumber;
            
        }
        public static string ScrubPhone(string phoneNumber, char charToRemove, char charToReplaceWith)
        {
            phoneNumber = phoneNumber.Replace(charToRemove, charToReplaceWith).Trim();
            return phoneNumber;

        }

    }
}
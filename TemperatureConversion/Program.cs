namespace TemperatureConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(celcius * 9 / 5) + 32
            while (true)
            {

                Console.WriteLine("1 CtoF 2 FtoC 3 Quit");
                Console.WriteLine("Enter your choice");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {//CtoF
                        case 1:
                            Console.WriteLine("Enter a Celsius temperature:");
                            double tempFarenheit = double.Parse(Console.ReadLine());
                            double tempCelcius = (tempFarenheit * 9 / 5) + 32;
                            Console.WriteLine($"Temperature in Farenheit: {tempCelcius:F2}");
                            break;
                            //FtoC
                            case 2:
                            Console.WriteLine("Enter a Celsius temperature:");
                            double tempCelcius1 = double.Parse(Console.ReadLine());
                            double tempFarenheit1 = (tempCelcius1 - 32) * 5 / 9;
                            Console.WriteLine($"Temperature in Celcius: {tempFarenheit1:F2}");
                            break; 
                        case 3:
                            Environment.Exit(0);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }
                {

                }
                
            //double tempFarenheit = 34.3;
            
           // double tempCelcius = (tempFarenheit - 32) * 5 / 9;

           // Console.WriteLine($"{tempFarenheit} °F is same as {tempCelcius} °C");
        }
    }
}
namespace TemperatureConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempFarenheit = 34.3;
            
            double tempCelcius = (tempFarenheit - 32) * 5 / 9;

            Console.WriteLine($"{tempFarenheit} °F is same as {tempCelcius} °C");
        }
    }
}
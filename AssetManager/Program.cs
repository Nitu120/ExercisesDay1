namespace AssetManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asset[] assets = new Asset[5];
            assets[0] = new Stock(1, "microsoft stock", new DateTime(2022, 1, 1),
                120, "MSFT", 130, 4);
            assets[1] = new Stock(2, "Amazon stock", new DateTime(2023, 1, 1),
                120, "AMZN", 130, 4);
            assets[2] = new Stock(3, "Google stock", new DateTime(2020, 1, 1),
                120, "GOOG", 130, 4);

            assets[3] = new Car(3, "Toyata", new DateTime(2020, 5, 12), 1000, 2019, 60000);

            assets[4] = new Car(4, "SUZUKI", new DateTime(2021, 7, 3), 1000, 2015, 60000);

            Console.WriteLine("Description\t\tDate Acquired\tValue");
            foreach (var item in assets) 
            {
                Console.WriteLine($"{item.Description}"+
                    $"\t{item.DateAcquired.ToShortDateString()}\t{item.GetValue()}");
            }
            Console.WriteLine("------Car Info------");
            foreach(var item in assets)
            {
                if(item is Car car) 
                {
                    Console.WriteLine(car);
                } 
            }

            Console.WriteLine("------Stock Info------");
            foreach (var item in assets)
            {
                if (item is Stock stock)
                {
                    Console.WriteLine(stock);
                }
            }
        }
    }
}
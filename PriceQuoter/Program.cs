namespace PriceQuoter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Code and Quantity");
            string productCode = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            double discount = 0.15;


            switch (productCode)
            {
                case "BG-127":
                    if (quantity < 25)
                    {
                        price = quantity * 18.99;
                        Console.WriteLine($"The price is {price:C}");
                    }
                    else if (quantity >= 25 && quantity < 50)
                    {
                        price = quantity * 17.00;
                        Console.WriteLine($"The price is {price:C}");

                    }
                    else if (quantity >= 50 && quantity < 250)
                    {
                        price = quantity * 14.49;
                        Console.WriteLine($"The price is {price:C}");
                    }
                    else if (quantity >= 250)
                    {
                        price = (quantity * 14.49) * discount;
                        price -= discount;
                        Console.WriteLine("You got discount");
                        Console.WriteLine($"The price is {price:C}");



                    }
                   
                    break;
                case "WRTR-28":
                    if (quantity < 25)
                    {
                        price = quantity * 125.00;
                        Console.WriteLine($"The price is {price:C}");
                    }
                    else if (quantity >= 25 && quantity < 50)
                    {
                        price = quantity * 113.75;
                        Console.WriteLine($"The price is {price:C}");

                    }
                    else if (quantity >= 50 && quantity < 250)
                    {
                        price = quantity * 99.99;
                        Console.WriteLine($"The price is {price:C}");
                    }
                    else if (quantity >= 250)
                    {
                        price = (quantity * 99.99) * discount;
                        price -= discount;
                        Console.WriteLine("You got discount");
                        Console.WriteLine($"The price is {price:C}");



                    }
                    break;
                case "GUAC-8":
                    if (quantity < 25)
                    {
                        price = quantity * 8.99;
                        Console.WriteLine($"The price is {price:C}");
                    }
                    else if (quantity >= 25 && quantity < 50)
                    {
                        price = quantity * 8.99;
                        Console.WriteLine($"The price is {price:C}");

                    }
                    else if (quantity >= 50 && quantity < 250)
                    {
                        price = quantity * 7.49;
                        Console.WriteLine($"The price is {price:C}");
                    }
                    else if (quantity >= 250)
                    {
                        price = (quantity * 7.49) * discount;
                        price -= discount;
                        Console.WriteLine("You got discount");
                        Console.WriteLine($"The price is {price:C}");



                    }
                    break;
                default:
                    Console.WriteLine("Invalid request");
                    break;
                










            }
             




        }
    }
}
namespace Searcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Sausage Breakfast Taco",
"Potato and Egg Breakfast Taco", "Sausage and Egg Biscuit",
"Bacon and Egg Biscuit", "Pancakes"};
            decimal[] prices = { 3.99M, 3.29M, 3.70M, 3.99M, 4.79M  };

            Console.WriteLine("Enter food you want to order");
            string order = Console.ReadLine();

            decimal? price = FindItemPrice(items, prices, order);
            Console.WriteLine($"{(price.HasValue ? price.Value:"Item not found")}");

            }

        private static decimal? FindItemPrice(string[] items, decimal[] prices, string order)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (order == items[i])
                {
                    return prices[i];
                }
                
            }
            return null;
        }
    }
    }

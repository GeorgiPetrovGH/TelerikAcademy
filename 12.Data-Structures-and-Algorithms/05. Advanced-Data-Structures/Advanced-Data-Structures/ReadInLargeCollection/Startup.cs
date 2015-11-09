namespace ReadInLargeCollection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            OrderedBag<Product> products = new OrderedBag<Product>();
            for (int i = 0; i < 500000; i++)
            {
                products.Add(new Product("Product #" + i, i%1000));                
            }

            var productsWithPrice10to15 = GetProductsByPriceRange(products, 10, 15, 20);
            Console.WriteLine("First 20 products with prices from 10.00 to 15.00");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPrice10to15));
        }

        public static IEnumerable<Product> GetProductsByPriceRange(OrderedBag<Product> products, decimal from, decimal to, int count)
        {
            var result =
                products.Range(
                    products.FirstOrDefault(x => x.Price >= from),
                    true,
                    products.LastOrDefault(x => x.Price <= to),
                    true).Take(count);

            return result;
        }
    }
}

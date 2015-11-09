namespace TradeCompany
{
    using System;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(true);

            Console.WriteLine("Start adding 2 000 000 elements(Will take some time):");
            for (int i = 0; i < 2000000; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.Write(".");
                }
                articles.Add(i, new Article ("Article #" + i, i%1000, "Vendor #" + i, i.ToString()));
            }

            Console.WriteLine();
            Console.WriteLine("Elements added.");

            Console.WriteLine("Getting elements in price range 1000 - 2000:");
            var articlesInRange = articles.Range(1000, true, 2000, true).Values;
            Console.WriteLine("{0} elements in this price range.", articlesInRange.Count);
        }
    }
}

namespace BiDictionary
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var biDict = new BiDictionary<string, int, string>();

            biDict.Add("key #1", 1, "value 11");
            biDict.Add("key #1", 2, "value 12");
            biDict.Add("key #1", 3, "value 13");
            biDict.Add("key #2", 1, "value 21");
            biDict.Add("key #2", 2, "value 22");
            biDict.Add("key #2", 3, "value 23");

            Console.WriteLine(biDict.FindByFirstKey("key1"));

            Console.WriteLine(biDict.FindBySecondKey(1));

            Console.WriteLine(biDict.FindByTwoKeys("key1", 3));
        }
    }
}

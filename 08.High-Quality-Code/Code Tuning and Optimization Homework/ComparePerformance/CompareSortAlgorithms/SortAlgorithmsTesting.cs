namespace CompareSortAlgorithms
{
    using System;

    public class SortAlgorithmsTesting
    {
        public static void Main()
        {
            string separator = new string('=', 60);

            SortingAlgorithmsPerformanceTester.TestIntSortingPerformance();
            Console.WriteLine(separator);
            SortingAlgorithmsPerformanceTester.TestDoubleSortingPerformance();
            Console.WriteLine(separator);
            SortingAlgorithmsPerformanceTester.TestStringSortingPerformance();
        }
    }
}

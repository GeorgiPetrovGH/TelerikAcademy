namespace Assertions
{
    using System;
    class AssertionsHomework
    {
       static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Sort_Utils.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            Sort_Utils.SelectionSort(new int[0]); // Test sorting empty array
            Sort_Utils.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(Search_Utils.BinarySearch(arr, -1000));
            Console.WriteLine(Search_Utils.BinarySearch(arr, 0));
            Console.WriteLine(Search_Utils.BinarySearch(arr, 17));
            Console.WriteLine(Search_Utils.BinarySearch(arr, 10));
            Console.WriteLine(Search_Utils.BinarySearch(arr, 1000));
        }
    }
}

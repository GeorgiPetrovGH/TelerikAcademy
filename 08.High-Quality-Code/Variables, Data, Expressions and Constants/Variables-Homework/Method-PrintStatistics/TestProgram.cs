namespace Method_PrintStatistics
{
    using System;
    class TestProgram
    {
        static void Main()
        {
            double[] numbers = new double[] { 11.2, -189.2, 6.2, 3.5, 0.0, -15.8, -12.5, 170.2 };
            ArrayMethods.PrintStatistics(numbers);
        }
    }
}

namespace ClassSizeInCSharp
{
    using System;
    class TestProgram
    {
        static void Main()
        {
            var initialSize = new Size(7.0, 14.0);
            var sizeAfterRotation = initialSize.GetRotatedSize(45.0);

            Console.WriteLine(initialSize);
            Console.WriteLine(sizeAfterRotation);
        }
    }
}

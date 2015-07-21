namespace Quality_Methods
{
    using System;    
    class TestProgram
    {
        static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.DigitToString(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintAsNumber(1.3, "f");
            Methods.PrintAsNumber(0.75, "%");
            Methods.PrintAsNumber(2.30, "r");
            
            Point2D pointX = new Point2D(3, -1),
                    pointY = new Point2D(2, 2.5);
            bool arePointsHorizontal = Point2D.isHorizontal(pointX, pointY),
                 arePointsVertical = Point2D.isVertical(pointX, pointY);
            double distance = Point2D.CalculateDistanceBetweenTwoPoints(pointX, pointY);

            Console.WriteLine(distance);
            Console.WriteLine("Horizontal? " + arePointsHorizontal);
            Console.WriteLine("Vertical? " + arePointsVertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, gamer, high results");            

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}

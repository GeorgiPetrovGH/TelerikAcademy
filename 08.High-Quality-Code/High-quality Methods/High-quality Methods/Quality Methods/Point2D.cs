namespace Quality_Methods
{
    using System;
    public class Point2D
    {
        public Point2D(double x, double y)
        {
            this.X_Coordinate = x;
            this.Y_Coordinate = y;
        }
        public double X_Coordinate { get; private set; }
        public double Y_Coordinate { get; private set; }

        public static bool isHorizontal(Point2D firstPoint, Point2D secondPoint)
        {
            return firstPoint.Y_Coordinate == secondPoint.Y_Coordinate;
        }

        public static bool isVertical(Point2D firstPoint, Point2D secondPoint)
        {
            return firstPoint.X_Coordinate == secondPoint.X_Coordinate;
        }

        public static double CalculateDistanceBetweenTwoPoints(Point2D firstPoint, Point2D secondPoint)
        {
            double horizontalDifference = firstPoint.X_Coordinate - secondPoint.X_Coordinate;
            double verticalDifference = firstPoint.Y_Coordinate - secondPoint.Y_Coordinate;
            double distance = System.Math.Sqrt((horizontalDifference * horizontalDifference) + (verticalDifference * verticalDifference));

            return distance;
        }
    }
}

/*
Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
*/

using System;
class TriangleCalculations
{
    static void Main()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double h = 4;
        double angle = Convert.ToDouble((Math.PI * 90) / 180);
        SurfaceBySideAndAttitude(a, h);
        SurfaceByThreeSides(a, b, c);
        SurfaceByTwoSidesAndAngleBetweenThem(a, b, angle);
    }

    static void SurfaceBySideAndAttitude(double side, double att)
    {
        double surface = (side * att) / 2;
        Console.WriteLine("Surface by side and attitude to it: {0}", surface);
    }
    static void SurfaceByThreeSides(double s1, double s2, double s3)
    {
        double p = (s1 + s2 + s3) / 2;
        double surface = Convert.ToDouble(Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3)));
        Console.WriteLine("Surface by all sides: {0}", surface);
    }
    static void SurfaceByTwoSidesAndAngleBetweenThem(double s1, double s2, double ang)
    {
        double surface = Convert.ToDouble((s1 * s2 * Math.Sin(ang)) / 2);
        Console.WriteLine("Surface by two sides and angle between them: {0}", surface);
    }
}


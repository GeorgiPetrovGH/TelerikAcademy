namespace Good_Abstraction
{
    using System;
    class TestProgram
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(2, 5);
            Console.WriteLine("Rect Perimeter = {0}", rect.GetPerimeter());
            Console.WriteLine("Rect Surface = {0}", rect.GetSurface());

            Circle circle = new Circle(5);
            Console.WriteLine("Circle Perimeter = {0}", circle.GetPerimeter());
            Console.WriteLine("Circle Surface = {0}", circle.GetSurface());
        }
    }
}

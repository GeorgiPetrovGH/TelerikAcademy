using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D();
            Console.WriteLine("non paramater constructor point + point.O");
            Console.WriteLine(point);
            Console.WriteLine(Point3D.O);

            Path testPath = new Path();
            testPath.AddPoint(new Point3D(1, 1, 1));
            testPath.AddPoint(new Point3D(2, 2, 2));
            testPath.AddPoint(new Point3D(3, -3, 3));

            Console.WriteLine("All points in text file:");
            PathStorage.Save(testPath, "Test");
            Path loadedPath = PathStorage.Load("Test");
            foreach (var item in loadedPath)
            {
                Console.WriteLine(item);
            }
        }
    }
}

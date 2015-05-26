using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application01
{
    public static class PathStorage
    {
        public static void Save(Path path, string pathName)
        {
            string fullPath = @"..//..//Path" + pathName + ".txt";
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (var item in path)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static Path Load(string pathName)
        {
            Path path = new Path();
            string fullPath = @"..//..//Path" + pathName + ".txt";

            try
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    while (reader.EndOfStream == false)
                    {
                        string[] coordinates = reader.ReadLine().Split(' ');
                        Point3D nextPoint = new Point3D(double.Parse(coordinates[0]), double.Parse(coordinates[1]), double.Parse(coordinates[2]));
                        path.AddPoint(nextPoint);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Write("The path \"{0}\" cannot be found.", pathName);
                return null;
            }

            return path;
        }
    }
}

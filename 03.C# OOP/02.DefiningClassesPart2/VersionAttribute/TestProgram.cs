using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace VersionAttribute
{
    [Version(VersionAttribute.Type.Class, "TestAttribute", "2.11")]
    class TestProgram
    {
        static void Main(string[] args)
        {
            var attr = typeof(TestProgram).GetCustomAttributes<VersionAttribute>();
            foreach (var attribute in attr)
            {
                Console.WriteLine("{0}: {1} Version: {2}",
                attribute.Component, attribute.Name, attribute.Version);
            }
        }
    }
}

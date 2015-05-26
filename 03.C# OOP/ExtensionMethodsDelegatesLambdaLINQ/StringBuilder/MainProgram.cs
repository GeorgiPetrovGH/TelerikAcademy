using System;
using System.Text;

namespace StringBuilderExtensionMethod
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            string test = "Teleric Academy";
            StringBuilder sb = new StringBuilder(test);            
            Console.WriteLine(sb.Substring(8));
            Console.WriteLine(sb.Substring(8,7));
        }
    }
}

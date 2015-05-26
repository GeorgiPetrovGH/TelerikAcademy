/*
Problem 7. Timer

Using delegates write a class Timer that can execute certain method at each t seconds.
*/

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerNamespace
{
    class MainProgram
    {
        static void Main()
        {
            Timer t = new Timer(10);
            t.IntervalPassed += Tick;
            t.Run();
        }

        static void Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");
        }
    }
}

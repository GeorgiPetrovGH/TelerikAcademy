namespace ClassChef
{
    using System;
    class TestProgram
    {
        static void Main()
        {
            var chef = new Chef();
            var bowl = chef.Cook();
            Console.WriteLine(bowl);
        }
    }
}

namespace Person
{
    using System;
    class MainProgram
    {
        static void Main()
        {
            var female = new Person();
            female = female.CreatePerson(25);
            var male = new Person();
            male = male.CreatePerson(26);

            Console.WriteLine(female);
            Console.WriteLine(male);
        }
    }
}

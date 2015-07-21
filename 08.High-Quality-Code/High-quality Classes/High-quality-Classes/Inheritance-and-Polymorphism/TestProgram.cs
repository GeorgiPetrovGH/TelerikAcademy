namespace Inheritance_and_Polymorphism
{
    using System;
    using System.Collections.Generic;
    class TestProgram
    {
        static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases", "Nikolay Kostov", "Ultimate");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.AddStudents(new List<string>() { "Peter", "Maria" });
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", "Mario Peshev",
                new List<string>() { "Thomas", "Ani", "Steve" },"Burgas");
            Console.WriteLine(offsiteCourse);
        }
    }
}

namespace School
{
    using System;
    class TestProgram
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "Peshev", 10100);
            Student gosho = new Student("Gosho", "Goshev", 10200);

            Console.WriteLine("Pesho number: {0}; Gosho number: {1}", pesho.UniqueNumber, gosho.UniqueNumber);
            Console.WriteLine("{0}; {1}", pesho.Name, gosho.Name);

            Course math = new Course("Math");
            math.AddStudent(pesho);
            math.AddStudent(gosho);

            Console.WriteLine("Students list count after adding 2 students: " + math.Students.Count);

            math.RemoveStudent(pesho);

            Console.WriteLine("Students list count after removing 1 student: " + math.Students.Count);
            Console.WriteLine(gosho.Courses.Count);
        }
    }
}

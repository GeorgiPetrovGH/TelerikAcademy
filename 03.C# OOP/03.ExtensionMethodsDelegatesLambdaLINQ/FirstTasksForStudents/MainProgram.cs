using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTasksForStudents
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Student[] students = {new Student("Nikolay","Kostov",20),
                                  new Student("Doncho","Minkov",22),
                                  new Student("Ivaylo","Kenov",24),
                                  new Student("Evlogi","Hristov",26),
                                  new Student("Svetlin","Nakov",28),};

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            var result = FirstNameBeforeLast(students);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students with first name before last:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            result = AgeInRange(students, 18, 24);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students with age in [18-24]:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            /*
            Problem 5. Order students
            Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
            Rewrite the same with LINQ.
            */
            result = students
                        .Select(x => x)
                        .OrderByDescending(x => x.FirstName)
                        .ThenByDescending(x => x.LastName);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students in descending order:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        /*
        Problem 3. First before last
        Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        Use LINQ query operators.
         */
        private static IEnumerable<Student> FirstNameBeforeLast(Student[] students)
        {
            IEnumerable<Student> result =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

            return result;
        }


        /*
        Problem 4. Age range
        Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        */
        private static IEnumerable<Student> AgeInRange(Student[] students, int minAge, int maxAge)
        {
            IEnumerable<Student> result =
            from student in students
            where student.Age >= minAge && student.Age <= maxAge
            select student;
            return result;
        }
    }
}

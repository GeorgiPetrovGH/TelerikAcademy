using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class MainProgram
    {
        static void Main()
        {
            Student sampleStudent01 = new Student ("Nikolay", "Kostov", "111105", "02200300", "nikolay@abv.bg", new List<int>{3, 2, 4, 6}, 1);
            Student sampleStudent02 = new Student ("Doncho", "Minkov", "222205", "0888200300", "doncho@abv.bg", new List<int> { 4, 2, 2, 5 }, 2);
            Student sampleStudent03 = new Student("Ivaylo", "Kenov", "333306", "+35928200300", "ivaylo@gmail.com", new List<int> { 4, 5, 5, 6 }, 2);
            Student sampleStudent04 = new Student("Evlogi", "Hristov", "444406", "+359886200300", "evlogi@yahoo.com", new List<int> { 6, 5, 5, 6 }, 3);
            Student sampleStudent05 = new Student("Svetlin", "Nakov", "555504", "+359886300400", "evlogi@yahoo.com", new List<int> { 4, 6, 6, 6 }, 1);

            List<Student> sampleStudents = 
                new List<Student> { sampleStudent01, sampleStudent02, sampleStudent03, sampleStudent04, sampleStudent05 };

            /*
             Problem 9. Student groups
             Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
             Create a List<Student> with sample students. Select only the students that are from group number 2.
             Use LINQ query. Order the students by FirstName.
            */
            #region Solving Problem 09
            //problem 9
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students from group 2:");
            Console.WriteLine(new string('-', 30));
            var studentsFromGroup2 =
                                from student in sampleStudents
                                where student.GroupNumber == 2
                                select student;

            var orderedStudentsFromGroup2 =
                                from student in studentsFromGroup2
                                orderby student.FirstName
                                select student;

            foreach (var st in orderedStudentsFromGroup2)
            {
                Console.WriteLine(st);
                Console.WriteLine();
            }
            #endregion

            /*
             Problem 10. Student groups extensions
             Implement the previous using the same query expressed with extension methods.
            */
            #region Solving Problem 10
            //problem 10
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students from group 2(using extension methods):");
            Console.WriteLine(new string('-', 30));
            
            var orderedStudents2 = sampleStudents.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);
            
            foreach (var st in orderedStudents2)
            {
                Console.WriteLine(st);
                Console.WriteLine();
            }
            #endregion

            /*
             Problem 11. Extract students by email
             Extract all students that have email in abv.bg.
             Use string methods and LINQ.
            */
            #region Solbing Problem 11
            //problem 11
            var studentsWithEmailsInAbv =
                                from student in sampleStudents
                                where student.Email.Contains("@abv.bg")
                                select student;

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students with email in abv:");
            Console.WriteLine(new string('-', 30));

            foreach (var st in studentsWithEmailsInAbv)
            {
                Console.WriteLine(st);
                Console.WriteLine();
            }
            #endregion

            /*
             Problem 12. Extract students by phone
             Extract all students with phones in Sofia.
             Use LINQ.
            */
            #region Solbing Problem 12
            //problem 12
            var studentsWithPhonesInSofia =
                                from student in sampleStudents
                                where student.Tel.StartsWith("02") || student.Tel.StartsWith("+3592")
                                select student;

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students with phone in Sofia:");
            Console.WriteLine(new string('-', 30));

            foreach (var st in studentsWithPhonesInSofia)
            {
                Console.WriteLine(st);
                Console.WriteLine();
            }
            #endregion

            /*
             Problem 13. Extract students by marks
             Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
             Use LINQ.
            */
            #region Solving Problem 13
            var studentsWithExcellentMark =
                                from student in sampleStudents
                                where student.Marks.Contains(6)
                                select new
                                {
                                    FullName = student.FirstName + " " + student.LastName,
                                    MarksList = student.Marks
                                };

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students with at least one excellent mark(6):");
            Console.WriteLine(new string('-', 30));
            
            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }            
            #endregion

            /*
             Problem 14. Extract students with two marks
             Write down a similar program that extracts the students with exactly two marks "2".
             Use extension methods.
            */
            #region Solving Problem 14
            var studentsWithTwoTwos = sampleStudents.Where(x => x.Marks.FindAll(y => y == 2).Count == 2).
                                                     Select(x => new
                                                     {
                                                         FullName = x.FirstName + " " + x.LastName,
                                                         MarksList = x.Marks
                                                     });

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students with exactly two poor marks:");
            Console.WriteLine(new string('-', 30));

            foreach (var student in studentsWithTwoTwos)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }
            #endregion

            /*
             Problem 15. Extract marks
             Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            */
            #region Solving Problem 15

            var studentsFrom2006 = sampleStudents.Where(x => x.FN[4] == '0' && x.FN[5] == '6');
            var allMarksFrom2006 = new List<int>();
            foreach (var student in studentsFrom2006)
            {
                allMarksFrom2006.AddRange(student.Marks);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All marks from 2006:");
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("{0}", string.Join(", ", allMarksFrom2006));
            Console.WriteLine();
            #endregion

            /*
             Problem 16.* Groups
             Create a class Group with properties GroupNumber and DepartmentName.
             Introduce a property GroupNumber in the Student class.
             Extract all students from "Mathematics" department.
             Use the Join operator
            */
            #region Solving Problem 16

            Group group1 = new Group(1, "Mathematics");
            Group group2 = new Group(2, "Literature");
            Group group3 = new Group(3, "Computer Science");
            List<Group> departments = new List<Group> { group1, group2, group3 };

            var studentsFromMathDpt =
                                from someGroup in departments
                                where someGroup.GroupNumber == 1
                                join student in sampleStudents on someGroup.GroupNumber equals student.GroupNumber
                                select new 
                                { 
                                    Name = student.FirstName + " " + student.LastName,
                                    Department = someGroup.DepartmentName
                                };

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students in Mathematics Department:");
            Console.WriteLine(new string('-', 30));

            foreach (var student in studentsFromMathDpt)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            #endregion

            /*
            Problem 18. Grouped by GroupNumber
            Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            Use LINQ.
            */
            #region Solving Problem 18

            var groupedStudents =
                                from student in sampleStudents
                                group student by student.GroupNumber
                                into groups
                                select new
                                {
                                    Group = groups.Key,
                                    Students = groups.ToList()
                                };

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students sorted into groups:");
            Console.WriteLine(new string('-', 30));
            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n......................\n{1}", grouped.Group,
                string.Join("\r\n\r\n", grouped.Students));
            }
            Console.WriteLine();
            #endregion

            /*
            Problem 19. Grouped by GroupName extensions
            Rewrite the previous using extension methods.
            */
            #region Solving Problem 19
            var groupedStudents2 = sampleStudents.GroupBy(x => x.GroupNumber, (groupNumber, students) => new { Group = groupNumber, Students = students });

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("All students sorted into groups(using extension methods):");
            Console.WriteLine(new string('-', 30));
            foreach (var grouped in groupedStudents2)
            {
                Console.WriteLine("\nGroup: {0} Students:\n......................\n{1}", grouped.Group,
                string.Join("\r\n\r\n", grouped.Students));
            }
            Console.WriteLine();            
            #endregion

        }
    }
}

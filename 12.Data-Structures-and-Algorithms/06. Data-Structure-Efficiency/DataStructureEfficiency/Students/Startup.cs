namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var reader = new StreamReader("..\\..\\students.txt");
            var orderedStudents = new SortedDictionary<string, SortedSet<Student>>();

            string input = reader.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                string[] studentsInfo = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(x => x.Trim()).ToArray();

                string subject = studentsInfo[2];
                var student = new Student
                {
                    FirstName = studentsInfo[0],
                    LastName = studentsInfo[1]
                };

                if (!orderedStudents.ContainsKey(subject))
                {
                    orderedStudents.Add(subject, new SortedSet<Student>());
                }

                orderedStudents[subject].Add(student);
                input = reader.ReadLine();
            }

            foreach (var course in orderedStudents)
            {
                Console.WriteLine("{0}: {1}", course.Key, string.Join(", ", course.Value));
            }
        }
    }
}

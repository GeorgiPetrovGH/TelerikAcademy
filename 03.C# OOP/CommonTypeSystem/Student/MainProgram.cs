/*
Problem 1. Student class
Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail,
course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

Problem 2. IClonable
Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

Problem 3. IComparable
Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
and by social security number (as second criteria, in increasing order).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class MainProgram
    {
        static void Main()
        {
            Student student01 = new Student("Niki", "A.", "Kostov", "1234567890", "Sofia", "02123456", "niki@gmail.com",
                                            5, Student._University.SU, Student._Faculty.Informatics, Student._Specialty.Informatics);
            Student student02 = new Student("Ivo", "B.", "Kenov", "9876543210", "Sofia", "02654321", "ivo@gmail.com",
                                            5, Student._University.UASG, Student._Faculty.StructuralEngeneering, Student._Specialty.CivilEngineering);

            Console.WriteLine(student01);
            Console.WriteLine(student02);
            Console.WriteLine(student01 == student02);
            Console.WriteLine(student01.Equals(student01));
            Console.WriteLine(student01.Equals(student02));
            Console.WriteLine(student01 != student02);
        }
    }
}

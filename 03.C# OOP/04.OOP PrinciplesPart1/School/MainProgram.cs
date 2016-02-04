/*
 Problem 1. School classes

 We are given a school. In the school there are classes of students. Each class has a set of teachers.
 Each teacher teaches, a set of disciplines. Students have a name and unique class number. 
 Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises. 
 Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
 Your task is to identify the classes (in terms of OOP) and their attributes and operations,
 encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class MainProgram
    {
        static void Main()
        {
            var discipline01 = new Discipline("Math", 6, 12);
            var discipline02 = new Discipline("English", 10, 20);
            var listOfDisciplines01 = new List<Discipline>();
            var listOfDisciplines02 = new List<Discipline>();
            listOfDisciplines01.Add(discipline01);
            listOfDisciplines02.Add(discipline02);
            
            var teacher01 = new Teacher("Pesho", listOfDisciplines01);
            var teacher02 = new Teacher("Gosho", listOfDisciplines02);
            var listOfTeachers = new List<Teacher>();
            listOfTeachers.Add(teacher01);
            listOfTeachers.Add(teacher02);
            
            var student01 = new Student("Asan", 1);
            var student02 = new Student("Ahmed", 2);
            var listOfStudents = new List<Student>();
            listOfStudents.Add(student01);
            listOfStudents.Add(student02);
            var schoolClass01 = new SchoolClass("1A", listOfStudents, listOfTeachers);

            Console.WriteLine(schoolClass01);
            foreach (var st in schoolClass01.Students)
            {
                Console.WriteLine(st);
            }
            foreach (var t in schoolClass01.Teachers)
            {
                Console.WriteLine(t);
            }

            student01.MakeComment("Left math class.");
            Console.WriteLine("{0} : {1}",student01.Name,student01.Comment);
        }
    }
}

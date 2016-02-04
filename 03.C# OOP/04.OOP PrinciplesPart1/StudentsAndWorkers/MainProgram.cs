/*
 Problem 2. Students and workers

 Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade.
 Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() 
 that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
 Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
 Initialize a list of 10 workers and sort them by money per hour in descending order.
 Merge the lists and sort them by first name and last name.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class MainProgram
    {
        static void Main()
        {
            List<Student> students = new List<Student>
                                    {
                                    new Student("Ivan", "Ivanov", 5.5),
                                    new Student("Stamat", "Stamatov", 5.0),
                                    new Student("Georgi", "Georgiev", 5.25),
                                    new Student("Petar", "Petrov", 4.5),
                                    new Student("Kirilka", "Kirilova", 3.5),
                                    new Student("Stoyanka", "Stoyanova", 6.0),
                                    new Student("Krasi", "Krasev", 2),
                                    new Student("Tsonko", "Tsonev", 4.25),
                                    new Student("Dimitar", "Dimitrov", 3.75),
                                    new Student("Gachko", "Palagachev", 5.5),
                                    };
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Sorted Students");
            Console.WriteLine(new string('-', 30));
            var orderedByGrade = students.OrderBy(x => x.Grade);
            foreach (var student in orderedByGrade)
            {
                Console.WriteLine(student);
            }            

            List<Worker> workers = new List<Worker>
                                    {
                                    new Worker("Ivan", "Georgiev", 200, 6),
                                    new Worker("Petar", "Simeonov", 300, 7),
                                    new Worker("Georgi", "Stamatov", 175, 5.5),
                                    new Worker("Georgi", "Vasilev", 177.25, 10),
                                    new Worker("Petar", "Dimitrov", 700, 9.5),
                                    new Worker("Ivan", "Tsonev", 1000, 5),
                                    new Worker("Vesela", "Veselinova", 500, 7.5),
                                    new Worker("Kirilka", "Stoyanova", 600, 8.7),
                                    new Worker("Stamat", "Petrov", 425.5, 6.125),
                                    new Worker("Stamat", "Mitev", 550, 8),
                                    };

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Sorted Workers");
            Console.WriteLine(new string('-', 30));
            var orderedByEarning = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in orderedByEarning)
            {
                Console.WriteLine(worker);
            }            

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Students and Workers");
            Console.WriteLine(new string('-', 30));
            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            foreach (var person in merged)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}

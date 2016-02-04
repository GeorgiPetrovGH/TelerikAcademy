using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTasksForStudents
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string fName, string lName, int age)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.age = age;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can not be null or empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can not be null or empty.");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("Age must be between 0 and 150");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.age;
        }
    }
}

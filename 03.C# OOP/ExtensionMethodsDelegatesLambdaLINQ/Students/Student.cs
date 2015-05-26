/*
Problem 9. Student groups

Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private EmailValidator emailValidator = new EmailValidator();

        public Student(string first, string last, string fNumber, string tel, string email, List<int> allMarks, int group)
        {
            this.firstName = first;
            this.lastName = last;
            this.fN = fNumber;
            this.tel = tel;
            this.email = email;
            this.marks = allMarks;
            this.groupNumber = group;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
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
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public string Tel
        {
            get { return this.tel; }
            set
            {
                if (string.IsNullOrEmpty(value) || (value[0] != '+' && value[0] != '0'))
                {
                    throw new ArgumentException("Tel. cannot be null or empty and must start with + or 0");
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (!this.emailValidator.IsValidEmail(value))
                {
                    throw new ArgumentException("Invald email");
                }
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group number must be > 0");
                }
                this.groupNumber = value;
            }
        }

        public string FN
        {
            get { return this.fN; }
            set
            {
                bool isNumber = true;
                foreach (char ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        isNumber = false;
                    }
                }
                if (!isNumber)
                {
                    throw new ArgumentException("Faculty number must contain digits only");
                }
                this.fN = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\n" +
            "Group number: {3}\nMarks: {4}\nPhone: {5}\nEmail: {6}",
            this.firstName, this.lastName, this.fN, this.groupNumber,
            string.Join(", ", this.marks), this.tel, this.email);
        }
    }
}

namespace School
{
    using System;
    using System.Collections.Generic;
    public class Student
    {
        private const int MinValidIdValue = 10000;
        private const int MaxValidIdValue = 99999;
        
        private string firstName;
        private string lastName;
        private int uniqueNumber;
        private ICollection<Course> courses;

        public Student(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UniqueNumber = id;
            this.courses = new List<Course>();
        }

        /// <exception cref="ArgumentException" accessor="set">Student's first name cannot be null or empty</exception>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (Validator.StringIsInvalid(value))
                {
                    throw new ArgumentNullException("Student's first name cannot be null or empty");
                }
                
                this.firstName = value;
            }
        }

        /// <exception cref="ArgumentException" accessor="set">Student's last name cannot be null or empty</exception>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (Validator.StringIsInvalid(value))
                {
                    throw new ArgumentNullException("Student's last name cannot be null or empty");
                }
                
                this.lastName = value;
            }
        }

        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (!Validator.UniqueNumberIsInRange(value, Student.MinValidIdValue, Student.MaxValidIdValue))
                {
                    throw new ArgumentException(string.Format("Student ID must be in range [{0}; {1}]", Student.MinValidIdValue, Student.MaxValidIdValue));
                }

                this.uniqueNumber = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public void AttendCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null");
            }

            course.RemoveStudent(this);
        }
    }
}

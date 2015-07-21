namespace Inheritance_and_Polymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Course
    {
        private string name;
        private string teacherName;       

        protected Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        protected Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        protected Course(string name, string teacherName, ICollection<string> students)
            : this(name, teacherName)
        {
            if (students != null)
            {
                foreach (var student in students)
                {
                    this.Students.Add(student);
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateIfStringIsNullOrEmpty(value, "Course name");
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                Validator.ValidateIfStringIsNullOrEmpty(value, "Teacher name");
                this.teacherName = value;
            }
        }

        public ICollection<string> Students { get; private set; }

        public void AddStudents(params string[] students)
        {
            Validator.ValidateIfNull(students, "Students collection");

            foreach (var studentName in students)
            {
                Validator.ValidateIfStringIsNullOrEmpty(studentName, "Student name");
                this.Students.Add(studentName);
            }
        }

        public void AddStudents(IEnumerable<string> students)
        {
            Validator.ValidateIfNull(students, "Students collection");

            foreach (var studentName in students)
            {
                Validator.ValidateIfStringIsNullOrEmpty(studentName, "Student name");
                this.Students.Add(studentName);
            }
        }

        public string GetStudentsAsString()
        {
            string students = string.Format("{{ {0} }}", string.Join(", ", this.Students));
            
            return students;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string courseType = this.GetType().Name;
            result.AppendLine(courseType);
            result.AppendFormat("Name = {0}\n", this.Name);
            
            if (this.TeacherName != null)
            {
                result.AppendFormat("Teacher = {0}\n", this.TeacherName);                
            }
            result.AppendFormat("Students = {0}\n", this.GetStudentsAsString());            
            
            return result.ToString();
        }
    }
}

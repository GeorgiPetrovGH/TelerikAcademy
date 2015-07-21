namespace Inheritance_and_Polymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class LocalCourse: Course
    {
        private string lab;

        public LocalCourse(string courseName, string teacherName, string lab)
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName, ICollection<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                Validator.ValidateIfStringIsNullOrEmpty(value, "Lab name");
                this.lab = value;
            }
        }    

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendFormat("Lab = {0}\n", this.Lab);            

            return result.ToString();
        }
    }
}

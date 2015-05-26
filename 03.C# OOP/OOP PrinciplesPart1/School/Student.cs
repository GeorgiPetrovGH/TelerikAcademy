using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student: Person, IComment
    {
        private int classNumber;
        private string comment;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Class number must be greater than zero.");
                }
                this.classNumber = value;
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comment yet!";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        public void MakeComment(string text)
        {
            this.Comment = text;
        }

        public override string ToString()
        {
            return String.Format("Student: {0} Number: {1}",
            this.Name, this.classNumber);
        }
    }
}

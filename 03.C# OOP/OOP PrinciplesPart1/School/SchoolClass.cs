using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolClass : IComment
    {
        private string identifier;
        private string comment;

        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public SchoolClass(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.Identifier = identifier;
            this.Students = students;
            this.Teachers = teachers;
        }

        public string Identifier
        {
            get { return this.identifier; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class identifier cannot be empty or null.");
                }
                this.identifier = value;
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
            return String.Format("Class: {0}",
            this.identifier);
        }

    }
}

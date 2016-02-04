using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher: Person, IComment
    {
        private List<Discipline> disciplines;
        private string comment;

        public Teacher(string name, List<Discipline> listOfDisciplines)
            : base(name)
        {
            this.Disciplines = listOfDisciplines;
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException("Disciplines must be greater than zero.");
                }
                this.disciplines = value;
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
            return this.Name;
        }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Discipline name must be at least 2 symbols long");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative.");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises cannot be negative.");
                }
                this.numberOfExercises = value;
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
            return String.Format("{0} : Lectures: {1}, Exercises: {2}",
            this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}

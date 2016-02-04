using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than zero.");
                }
                this.age = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} Age: {1}", this.Name, this.Age == null ? "Unknown" : this.Age.ToString());
        }
    }
}

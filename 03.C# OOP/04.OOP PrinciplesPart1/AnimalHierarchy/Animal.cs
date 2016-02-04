using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        public enum Gender { Male, Female };

        private string name;
        private int age;
        private Gender sex;

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

        public int Age
        {
            get { return this.age; }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                this.age = value;
            }
        }

        public Gender Sex
        {
            get { return this.sex; }
            set
            {
                this.sex = value;
            }
        }

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public abstract void MakeSound();
    }
}

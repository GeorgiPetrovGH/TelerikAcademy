namespace Person
{
    using System;
    public class Person
    {
        public Person()
        {

        }
        public Sex Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person CreatePerson(int age)
        {
            Person person = new Person();
            person.Age = age;
            
            if (age % 2 == 0)
            {
                person.Name = "Reese";
                person.Gender = Sex.Male;
            }
            else
            {
                person.Name = "Rose";
                person.Gender = Sex.Female;
            }

            return person;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.Gender, this.Age);
        }
    }
}

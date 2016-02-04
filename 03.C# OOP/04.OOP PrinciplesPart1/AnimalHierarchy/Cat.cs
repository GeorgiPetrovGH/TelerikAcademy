using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Gender gender) : base(name, age, gender)
        {           
        }

        public override void MakeSound()
        {
            Console.WriteLine("{0} is meowing.", this.Name);
        }
    }
}

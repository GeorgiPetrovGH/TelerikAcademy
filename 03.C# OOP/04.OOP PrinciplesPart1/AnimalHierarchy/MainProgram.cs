/*
 Problem 3. Animal hierarchy

 Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
 All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex.
 Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
 Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class MainProgram
    {
        static void Main()
        {
            Animal[] animals =
                                {
                                new Dog("Rex", 3, Animal.Gender.Male),
                                new Dog("Jorko", 1, Animal.Gender.Male),
                                new Dog("Pepa", 5, Animal.Gender.Female),
                                new Dog("Pesho", 2, Animal.Gender.Male),
                                new Frog("Jabko", 1, Animal.Gender.Male),
                                new Frog("Kikerica", 3, Animal.Gender.Female),
                                new Cat("Maca", 5, Animal.Gender.Female),
                                new Cat("Pisana", 4, Animal.Gender.Female),
                                new Tomcat("Tom", 5),
                                new Tomcat("Gosho", 3),
                                new Kitten("Puhcho", 1),
                                };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);
            Console.WriteLine("Average age of the dogs: {0}", averageDogsAge);
            Console.WriteLine("Average age of the frogs: {0}", averageFrogsAge);
            Console.WriteLine("Average age of the cats: {0}", averageCatsAge);
        }
    }
}

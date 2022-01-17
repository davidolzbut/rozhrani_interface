using System;
using vlastnostiRozhrani1.Entity;

namespace vlastnostiRozhrani1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doggie1 = new Dog();
            doggie1.Play();

            Cat cat1 = new Cat();
            cat1.Play();

            IAnimal animal = new Dog();
            animal.Play();

            animal = new Cat();
            animal.Play();

        }
    }
}

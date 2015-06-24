using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_example_Dog_and_Cat
{
    public class Dog
    {
        public string name;
        public string breed;
        public int age;

        public Dog()
        {
            age = 0;
            name = "";
            breed = "";
        }

        public Dog(int age, string name, string breed)
        {
            this.age = age;
            this.name = name;
            this.breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine(this.name + " says woof woof!");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_example_Dog_and_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10, 100, 100);
            Console.WriteLine(c.Diameter);
            Console.WriteLine(c.Area);
            Console.WriteLine(c);
            
            Dog raven = new Dog();
            raven.age = 9;
            raven.name = "Raven";
            raven.breed = "Mix";

            Dog budda = new Dog();
            budda.age = 7;
            budda.name = "Budda";
            budda.breed = "Rottweiler";

            Dog beau = new Dog(8, "Beau", "Hunting");

            raven.Bark();
            budda.Bark();
            beau.Bark();

            Cat theo = new Cat();
            theo.name = "Theodore";

            theo.Meow();

            while(theo.isAlive)
            {
                theo.Die();
            }

            theo.Meow();

            Console.ReadLine();
        }
    }
}

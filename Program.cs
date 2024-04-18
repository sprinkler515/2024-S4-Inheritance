using _0416_S4_Inheritance.Bipeds;
using _0416_S4_Inheritance.Quadrupeds;

namespace _0416_S4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[][] animals = [new Biped[2], new Quadruped[3]];

            animals[0][0] = new Human("Adam");
            animals[0][1] = new Monkey("Caesar");
            animals[1][0] = new Elephant("Dumbo");
            animals[1][1] = new Turtle("Michelangelo");
            animals[1][2] = new Lizard("Croco");

            foreach(var animalCategory in animals)
                foreach(var animal in animalCategory)
                {
                    animal.DisplayInfos();
                    animal.Eat();
                    animal.Move();
                }
        }
    }
}

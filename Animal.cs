using System.Runtime.CompilerServices;

namespace _0416_S4_Inheritance
{
    public abstract class Animal(int legCounts)
    {
        protected int _legsCount = legCounts;
        protected bool _hairy;
        protected string? Name { get; set; }
        protected string? Species { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} eats");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} moves");
        }

        public void DisplayInfos()
        {
            Console.WriteLine($"------------------------------\n" +
                $"Name : {Name}\n" +
                $"Species : {Species}\n" +
                $"Hairless : {!_hairy}\n" +
                $"Number of legs: {_legsCount}"); 
        }
    }
}

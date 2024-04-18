namespace _0416_S4_Inheritance.Quadrupeds
{
    public abstract class Quadruped() : Animal(4)
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats on all fours");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} moves with {_legsCount} legs");
        }
    }
}

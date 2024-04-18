namespace _0416_S4_Inheritance.Bipeds
{
    public abstract class Biped() : Animal(2)
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats on {_legsCount} feets");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} moves with {_legsCount} legs");
        }
    }
}

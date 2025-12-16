namespace RPG_Game
{
    public class Goblin : Enemy
    {
        public Goblin() : base(40, 8, "Гоблін", 30)
        {

        }

        public override void Attack(Character target)
        {
            var damage = Strength;
            Console.WriteLine($"{Name} б'є кинджалом і завдає {damage} пошкоджень!");
            target.TakeDamage(damage);
        }
    }
}
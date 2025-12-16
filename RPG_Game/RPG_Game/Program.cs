namespace RPG_Game
{
    public class DarkMage : Enemy, ISpellCaster
    {
        private int _mana;

        public int Mana
        {
            get => _mana;
            private set => _mana = Math.Max(0, value);
        }

        public DarkMage() : base(60, 10, "Dark Mage", 80)
        {
            _mana = 100;
        }

        public override void Attack(Character target)
        {
            throw new NotImplementedException();
        }

        public void CastSpell(Character target)
        {
            throw new NotImplementedException();
        }

        public void RestoreMana(int amount)
        {
            Mana += amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
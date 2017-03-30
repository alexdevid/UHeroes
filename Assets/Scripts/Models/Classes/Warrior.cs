namespace Models.Classes
{
    public class Warrior : Hero
    {
        private const int CON = 43;
        private const int STR = 40;
        private const int DEX = 30;
        private const int INT = 21;

        private const double BASE_HP = 9.4;
        private const double BASE_MP = 6.9;
        
        public Warrior(string name, string className) : base(name, className, CON, STR, DEX, INT, BASE_HP, BASE_MP)
        {

        }
    }
}

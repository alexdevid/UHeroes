namespace Models.Classes
{
    public class Rogue : Hero
    {
        private const int CON = 36;
        private const int STR = 36;
        private const int DEX = 35;
        private const int INT = 24;

        private const double BASE_HP = 8.8;
        private const double BASE_MP = 7.0;
        
        public Rogue(string name, string className) : base(name, className, CON, STR, DEX, INT, BASE_HP, BASE_MP)
        {

        }
    }
}

namespace Models.Classes
{
    public class Mage : Hero
    {
        private const int CON = 27;
        private const int STR = 22;
        private const int DEX = 21;
        private const int INT = 41;

        private const double BASE_HP = 8.2;
        private const double BASE_MP = 7.8;
        
        public Mage(string name, string className) : base(name, className, CON, STR, DEX, INT, BASE_HP, BASE_MP)
        {

        }
    }
}

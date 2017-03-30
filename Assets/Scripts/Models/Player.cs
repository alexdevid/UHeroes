using UnityEngine;
using System.Collections.Generic;

namespace Models
{
    public class Player : MonoBehaviour
    {
        private List<Hero> heroes;
        private Hero hero;

        public static Player Instance;

        void Awake()
        {
            if (!Instance)
            {
                this.heroes = new List<Hero>();
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);
        }

        public List<Hero> GetHeroes()
        {
            return this.heroes;
        }

        public Hero GetHero()
        {
            return this.hero;
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void AddHero(Hero hero)
        {
            this.heroes.Add(hero);
        }
    }
}

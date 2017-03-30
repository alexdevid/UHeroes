using UnityEngine;
using System;
using System.Collections;

namespace Models
{
    abstract public class Hero
    {
        public const string CLASS_WARRIOR   = "warrior";
        public const string CLASS_ROGUE     = "rogue";
        public const string CLASS_MAGE      = "mage";

        private string name;
        private string className;

        protected int level;
        protected int currentExp = 0;
        protected int maxExp;

        private int CON;
        private int STR;
        private int DEX;
        private int INT;

        private int hp;
        private int mp;

        private double baseHP;
        private double baseMP;

        public Hero(string name, string className, int con, int str, int dex, int intl, double baseHP, double baseMP)
        {
            this.name = name;
            this.className = className;
            this.maxExp = 100; //TODO

            this.CON = con;
            this.STR = str;
            this.DEX = dex;
            this.INT = intl;

            this.baseHP = baseHP;
            this.baseMP = baseMP;

            this.hp = this.GetMaxHP();
            this.mp = this.GetMaxMP();
        }

        public string GetName()
        {
            return name;
        }

        public string GetClass()
        {
            return className;
        }

        public int GetHP()
        {
            return this.hp;
        }

        public int GetMP()
        {
            return this.mp;
        }

        public int GetMaxHP()
        {
            return Convert.ToInt32(this.CON * this.baseHP);
        }

        public int GetMaxMP()
        {
            return Convert.ToInt32(this.INT * this.baseMP);
        }

        public static Hero Create(string name, string className)
        {
            Debug.Log(className);

            if (className == CLASS_WARRIOR)
            {
                Debug.Log(className);
                return new Models.Classes.Warrior(name, className);
            }
            if (className == CLASS_ROGUE)
            {
                return new Models.Classes.Rogue(name, className);
            }
            if (className == CLASS_WARRIOR)
            {
                return new Models.Classes.Mage(name, className);
            }
            return null;
        }
    }
}

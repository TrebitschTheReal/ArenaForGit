using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class MonsterBuilder
    {
        private string name;
        private bool evilOrNot;
        private int health;
        private int armor;
        private int strength;
        private int speed;
        private int intelligence;
        private int attackRate;

        public MonsterBuilder(string name, bool evilOrNot, int health, int armor, int strength, int speed, int intelligence)
        {
            this.name = name;
            this.evilOrNot = evilOrNot;
            this.health = health;
            this.armor = armor;
            this.strength = strength;
            this.speed = speed;
            this.intelligence = intelligence;
            this.attackRate = strength + speed + intelligence;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public bool EvilOrNot
        {
            get { return this.evilOrNot; }
            set { this.evilOrNot = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int Armor
        {
            get { return this.armor; }
            set { this.armor = value; }
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            set { this.intelligence = value; }
        }

        public int AttackRate
        {
            get { return this.attackRate; }
            set { this.attackRate = value; }
        }
    }
}

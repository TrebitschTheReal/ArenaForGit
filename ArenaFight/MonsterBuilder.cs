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
        private int maxHealth;
        private int armor;
        private int strength;
        private int speed;
        private int intelligence;

        private int attackRate;
        private int actualHealth;

        public MonsterBuilder(string name, bool evilOrNot, int maxHealth, int armor, int strength, int speed, int intelligence)
        {
            this.Name = name;
            this.EvilOrNot = evilOrNot;
            this.MaxHealth = maxHealth;
            this.Armor = armor;
            this.Strength = strength;
            this.Speed = speed;
            this.Intelligence = intelligence;

            this.attackRate = (strength + speed + intelligence) / 2;
            this.actualHealth = maxHealth;
        }

        public string Name
        {
            get { return this.name; }  // akkor fut le, ha csak lekérdezzük az értéket. returnolja a "name" adattagot
            set // akkor fut le amikor módosítani is akarjuk magát a tulajdonságot. A tulajdonságnak ugyan az a neve mint az adattagnak koncenció szerint.
            { this.name = value; }
        }

        public bool EvilOrNot
        {
            get { return this.evilOrNot; }
            set { this.evilOrNot = value; }
        }

        public int MaxHealth
        {           
            get
            {
                return this.maxHealth;
            }
            set
            {
                if (value > 300) Exception("Health points value must be 300 or lower!");
                else this.maxHealth = value;
            }
        }

        public int Armor
        {
            get { return this.armor; }
            set
            {
                if (value > 100) Exception("Armor's maximum is 100");
                else this.armor = value;
            }
        }

        public int Strength
        {
            get { return this.strength; }
            set
            {
                if (value > 50) Exception("Strength, speed and intelligence maximum is 50");
                else this.strength = value;
            }
        }

        public int Speed
        {
            get { return this.speed; }
            set
            {
                if (value > 50) Exception("Strength, speed and intelligence maximum is 50");
                else this.speed = value;
            }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            set
            {
                if (value > 50) Exception("Strength, speed and intelligence maximum is 50");
                else this.intelligence = value;
            }
        }

        public int AttackRate
        {
            get { return this.attackRate; }
        }

        public int ActualHealth
        {
            get { return this.actualHealth; }
            set { this.actualHealth = value; }
        }

        private void Exception (string text)
        {
            throw new FormatException(text);
        }
    }
}

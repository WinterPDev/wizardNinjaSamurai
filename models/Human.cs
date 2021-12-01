using System;

namespace wizardNinjaSamurai
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health
        {
            get {return health;}
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public virtual void Attack(Human targ)
        {
            System.Console.WriteLine($"Enemy {targ.Name} : [{targ.health}]");
            int dmg = Strength*5;
            targ.health -= dmg;
            System.Console.WriteLine($"{Name} dealt {dmg} to Enemy {targ.Name} !");
            System.Console.WriteLine($"Enemy {targ.Name} : [{targ.health}]");
        }
    }

}
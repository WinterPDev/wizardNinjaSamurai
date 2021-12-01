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
            get{return health;}
            set{health = value;}
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
        }

        // public virtual void Attack(Human target, int dmg)
        // {
        //     if (target.health < dmg){
        //         target.health = 0;
        //     }
        //     else
        //     {
        //         target.health -= dmg;
        //     }
        // }

        // public int Healed(Human target, int hp)
        // {
        //     target.health += hp;
        //     return target.health;
        // }
    }

}
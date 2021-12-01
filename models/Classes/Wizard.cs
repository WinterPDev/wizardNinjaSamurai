using System;

namespace wizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }

        public override void Attack(Human targ)
        {
            int dmg = Intelligence*5;
            targ.health -= dmg;
        }
    }
}
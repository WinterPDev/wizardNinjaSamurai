using System;

namespace wizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name, 3, 3, 3, 200){}

        public override void Attack(Human target)
        {
            int dmg = Strength*3;
            if(target.Health < 50){
                Console.WriteLine($"{Name} Executed {target.Name}!");
                target.Health = 0;
            }
            else
            {
                Console.WriteLine($"{Name} Could Not Execute {target.Name}"!);
                target.Health -= dmg;
                System.Console.WriteLine($"{Name} dealt {dmg} to Enemy {target.Name} !");
            }
        }

        public void Meditate()
        {
            this.Health = 200;
            Console.WriteLine($"{Name} Meditated. . . Restored HP to {Health}");
        }
    }
}
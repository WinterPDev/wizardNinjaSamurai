using System;

namespace wizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100){}
        public override void Attack(Human target)
        {
            Random rand = new Random();
            int rng = rand.Next(100);
            int dmg = 5 * Dexterity;
            if(rng <= 20){
                Console.WriteLine($"{Name} Critically Striked! %{rng}");
                target.Health -= dmg + 10;
                System.Console.WriteLine($"{Name} dealt {dmg+10} to Enemy {target.Name} !");
            }
            else
            {
                Console.WriteLine($"{Name} failed to Critically Strike! %{rng}");
                target.Health -= dmg;
                System.Console.WriteLine($"{Name} dealt {dmg} to Enemy {target.Name} !");
            }
        }

        public void Steal(Human target)
        {
            int dmg = 5;
            Health += dmg;
            target.Health -= dmg;
            System.Console.WriteLine($"{Name} stole {dmg} from Enemy {target.Name} !");
            System.Console.WriteLine($"Player {Name} Gained {dmg} HP!");
        }

    }
}
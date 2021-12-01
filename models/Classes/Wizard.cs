using System;

namespace wizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50) {}
        public override void Attack(Human target)
        {
            int wiz_dmg = 5*Intelligence;
            System.Console.WriteLine($"Enemy {target.Name} : [{target.Health}]");
            if(target.Health < wiz_dmg){
                System.Console.WriteLine($"{Name} dealt {wiz_dmg} to Enemy {target.Name} !");
                System.Console.WriteLine($"Enemy {target.Name} Slain!");
                Health += target.Health;
                System.Console.WriteLine($"Player {Name} Gained {target.Health} HP!");
                System.Console.WriteLine($"Player {Name} : [{Health}]");
                target.Health = 0;
            }
            else
            {
                target.Health -= wiz_dmg;
                System.Console.WriteLine($"{Name} dealt {wiz_dmg} to Enemy {target.Name} !");
                Health += wiz_dmg;
                System.Console.WriteLine($"Player {Name} Gained {wiz_dmg} HP!");
                System.Console.WriteLine($"Enemy {target.Name} : [{target.Health}]");
            }
        }
        public void Heal(Human target)
        {
            int h = 10*Intelligence;
            System.Console.WriteLine($"Target {target.Name} has {target.Health} HP.");
            target.Health += h;
            System.Console.WriteLine($"Player {Name} Healed {target.Name} for {h} !");
            System.Console.WriteLine($"Target {target.Name} now has {target.Health} HP.");
        }
    }
}
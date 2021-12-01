using System;

namespace wizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wiz = new Wizard("Eluith");
            Wizard wiz2 = new Wizard("Athairne");
            Ninja nin = new Ninja("Honzo");
            Samurai sam = new Samurai("Takeda");

            wiz.Attack(wiz2);
            wiz.Heal(wiz2);
            nin.Attack(wiz);
            nin.Steal(wiz);
            sam.Attack(wiz);
            sam.Attack(nin);
            sam.Meditate();
        }
    }
}

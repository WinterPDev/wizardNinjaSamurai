using System;

namespace wizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {

            Wizard wiz = new Wizard("Eluith");
            System.Console.WriteLine(wiz.Name + " " + wiz.Intelligence + " " + wiz.Health + " " + wiz.Strength);
        }
    }
}

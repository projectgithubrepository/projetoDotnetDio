using System;
using dio_projetoDotnet.src.Entities;

namespace dio_projetoDotnet
{

    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 2, 5);
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard", 3, 4);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
﻿using System;
using Abstracao_RPG.src.Entities;

namespace Abstracao_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");


            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));

            
        }
    }
}

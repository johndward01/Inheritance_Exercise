using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise_01_Answers
{
    // TODO: Create a base class called Character
    public class Character
    {
        // TODO: Make all the members of the base class Protected

        // TODO: Give the Character class properties (be creative)
        protected int Health { get; set; }
        protected int Armor { get; set; }
        protected int Strength { get; set; }
        protected int Dexterity { get; set; }
        protected int Intelligence { get; set; }
        protected int Awareness { get; set; }
        protected int Constitution { get; set; }


        // TODO: Give the Character class basic attack and defend methods
        protected void Attack()
        {
            Console.WriteLine("Generic attack!");
        }

        protected void Defend()
        {
            Console.WriteLine("Generic defend!");
        }
    }
}

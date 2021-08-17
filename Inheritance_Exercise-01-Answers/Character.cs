using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise_01_Answers
{
    // TODO: Create a base class called Character
    public class Character
    {
        // TODO: Give the Character class properties (be cretive)
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Awareness { get; set; }
        public int Constitution { get; set; }


        // TODO: Give the Character class base attack and defend methods
        public virtual void Attack()
        {
            Console.WriteLine("Generic attack!");
        }

        public virtual void Defend()
        {
            Console.WriteLine("Generic defend!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise_01_Answers
{
    // TODO: Create a child class called MainCharacter that inherits from the base class
    public class MainCharacter : Character
    {
        // TODO: Make all members public

        // TODO: Give the MainCharacter class methods and properties (be creative)
        public new void Attack() // the 'new' keyword tells the compiler to overwrite the base class's Attack() method
        {
            Console.WriteLine("Main Character's special attack method!");
        }

        public new void Defend() // the 'new' keyword tells the compiler to overwrite the base class's Defend() method
        {
            Console.WriteLine("Main Character's special defense method!");
        }
    }
}

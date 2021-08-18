using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise_01_Answers
{
    // TODO: Create another child class called EnemyCharacter that inherits from the base class
    public class EnemyCharacter : Character
    {
        // TODO: Make all members public

        // TODO: Give the EnemyCharacter class methods and properties (be creative)
        public new void Attack() // the 'new' keyword tells the compiler to overwrite the base class's Attack() method
        {
            Console.WriteLine("Enemy Character's special attack method!");
        }

        public new void Defend() // the 'new' keyword tells the compiler to overwrite the base class's Defend() method
        {
            Console.WriteLine("Enemy Character's special defense method!");
        }
    }
}

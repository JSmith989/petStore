using System;
using System.Collections.Generic;
using System.Text;

namespace petstore.Pets
{
    public class Turtle
    {
        //Properies - externally consumable
        public string Name { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        //Fields - internal private things(sometimes has underscore)
        private bool _isHungry = true;

        //Constructor
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"{Name} is {Age} years old.");
        }

        //Method
        public void Eat(string foodType)
        {
            if(_isHungry)
            {
                Console.WriteLine($"The turtle stretches their neck out and munches on the {foodType}.");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine("Shakes its head and says no thank you.");
            }
            
        }

        public void ShowTime(string occasion)
        {
            if(occasion != null)
            {
                Console.WriteLine($"It is a {occasion}!");
            }
            else
            {
                Console.WriteLine($"No occasion...");
            }
            Console.WriteLine();
            DressUp("Tie");
        }

        //Method overloading
        public void Eat()
        {
            Eat("pellets");
        }

        private void DressUp(string clothing)
        {
            Console.WriteLine($"The turtle is wearing {clothing}.");
        }
    }
}

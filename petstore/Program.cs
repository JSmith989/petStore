using petstore.Pets;
using System;

namespace petstore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Turtle turtle1 = new Turtle("Mertle", 72);
            turtle1.Eat();
            turtle1.Eat("lettuce");
            turtle1.ShowTime("bar-mitzvah");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
        }
    }
}

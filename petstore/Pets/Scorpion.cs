using System;
using System.Collections.Generic;
using System.Text;

namespace petstore.Pets
{
    // a class is implicitly internal
    public class Scorpion
    {
        //Inside class things are implicitly private
        public int StingerWidth { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }
        public bool DoesGlow { get; set; } = true;

        //Constructor
        public Scorpion(string name)
        {
            Name = name;
        }

        //Methods
        public void Attack()
        {
            if (DoesGlow)
            {
                Console.WriteLine("SCORP ATTACK!");
            }
            else
            {
                Console.WriteLine("Scorpion is content.");
            }
        }
        

    }
}

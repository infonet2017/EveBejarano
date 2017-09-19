using System;
using System.Collections.Generic;
using System.Text;

namespace AngryBird
{
    class Bird
    {
        public int Hunger { get; set; }
        public int Weight { get; set; }


        public void Eat( int foot)
        {
            this.Hunger = this.Hunger - foot;
            this.Weight = this.Weight + foot;
        }

        public void Status()
        {
            Console.WriteLine("I'm a bird with a weight of {0} and a hunger level of {1}.", this.Weight, this.Hunger);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AngryBird
{
    class AngryBird: Bird
    {
        public int Anger { get; set; }

        public void Provoke(int fury)
        {
            if (this.Hunger > 0)
            {
                fury = 2 * fury;
            }

            this.Anger = this.Anger + fury;

        }

        public void StatusAngryBird()
        {
            Console.WriteLine("I'm a Angry-Bird with a weight of {0}, a hunger level of {1}, and an anger level of {2}.", this.Weight, this.Hunger, this.Anger);
        }
    }
}

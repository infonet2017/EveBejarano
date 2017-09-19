using System;

namespace AngryBird
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird();
            bird.Hunger = 100;
            bird.Weight = 50;
            bird.Status();

            bird.Eat(20);
            bird.Status();

            var Angrybird = new AngryBird();
            Angrybird.Hunger = 100;
            Angrybird.Weight = 50;
            Angrybird.Anger = 50;
            Angrybird.StatusAngryBird();

            Angrybird.Provoke(5);
            Angrybird.StatusAngryBird();


            Angrybird.Eat(100);
            Angrybird.Provoke(5);
            Angrybird.StatusAngryBird();
            Console.Read();

        }
    }
}

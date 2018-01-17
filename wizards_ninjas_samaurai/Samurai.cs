using System;

namespace wizards_ninjas_samaurai
{
    public class Samurai : Human
    {

        public static int counter = 0;
        public Samurai(string n) : base(n)
        {
            counter++;
            health = 200;
        }
        public void death_blow(object target)
        {
            Human enemy = target as Human;
            if (enemy.health < 50)
            {
                enemy.health = 0;
            }
        }

        public void meditate()
        {
            health = 200;
        }

        public static void how_many()
        {
            Console.WriteLine(counter);
        }
    }
}

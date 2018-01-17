using System;

namespace wizards_ninjas_samaurai
{
    public class Ninja : Human
    {
        public Ninja(string n) : base(n)
        {
            dexterity = 175;
        }
        public void Steal(object obj)
        {
            Human target = obj as Human;
            {
                attack(target);
                health += 10;
            }
        }
        public void get_away()
        {
            health -= 15;
        }
    }
}
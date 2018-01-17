using System;
using System.Collections.Generic;

namespace wizards_ninjas_samaurai
{
  public class Wizard : Human
    {
        public Wizard(string n) : base(n)
        {
            name = n;
            intelligence = 25;
            health = 50;
        }
        public void Heal(){
            health += 10 * intelligence;
        }
        public void Fireball(object obj){
            Random rand = new Random();
            Human target = obj as Human;
            target.health -= rand.Next(20,51);
        }
    }
}
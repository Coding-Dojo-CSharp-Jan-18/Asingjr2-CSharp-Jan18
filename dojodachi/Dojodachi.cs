using System;
using Newtonsoft.Json;

namespace dojodachi
{
   
   class DD{
    public int happiness = 20;
    public int fullness = 20;
    public int energy = 50;
    public int meals = 3;
    public DD Play() 
    {
       if (this.energy > 5)
            {
                this.energy -= 5;
                Random rand = new Random();
                int happinessChange = rand.Next(5, 11);
                this.happiness += happinessChange;
                return this;
            }
        else
            {
                System.Console.WriteLine("There is not enough energy to play");
                return this;
            }
        }

//Feeding your Dojodachi costs 1 meal and gains a random amount of fullness between 5 and 10 (you cannot feed your Dojodachi if you do not have meals)    
    public DD Feed()
    {
        if(this.meals > 0)
            { 
                this.meals -= 1; 
                Random rand = new Random();
                int fullnessChange = rand.Next(5,11);
                this.fullness += fullnessChange; 
                return this;
            }
        else
            { 
            System.Console.WriteLine("There are no meals to give");
            return this;
            }  
    }
    // Sleeping earns 15 energy and decreases fullness and happiness each by 5
    public DD Sleep()
    {
        if (this.happiness > 4 && this.fullness > 4)
        {
            this.energy += 15;
            this.happiness -=5;
            this.fullness -=5;
            return this;
        }
        else 
        {
            System.Console.WriteLine($"You do not have enough happiness or fullness to sleep.  Current happiness is {0} and current fullness is {1}", this.happiness, this.fullness);
            return this;
        }
    }
    // Working costs 5 energy and earns between 1 and 3 meals
    public DD Work()
    {
        if (this.energy > 4)
            {
                this.energy -= 5;
                Random rand = new Random();
                int happinessChange = rand.Next(5, 11);
                this.happiness += happinessChange;
                return this;
            }
            else if (this.energy >0)
            {
                System.Console.WriteLine("There is not enough energy to work");
                return this;
            }
            else
            {
                System.Console.WriteLine("there are no energy left");
                return this;
            }
    }
   }
}
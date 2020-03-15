using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<LunchBuddy> companions = new List<LunchBuddy> { };

            var lunchBud1 = new LunchBuddy("Joe", "Schmoe");
            var lunchBud2 = new LunchBuddy("Laura", "Downing");
            var lunchBud3 = new LunchBuddy("Alice", "Smith");
            var lunchBud4 = new LunchBuddy("Stevie", "Jones");

            companions.Add(lunchBud1);
            companions.Add(lunchBud2);
            companions.Add(lunchBud3);
            companions.Add(lunchBud4);

            var LunchBuddy1 = new LunchBuddy("Mike", "Smith");
            LunchBuddy1.Eat();
            LunchBuddy1.Eat("tacos");
            lunchBud4.Eat(companions);
            LunchBuddy1.Eat("burritos", companions);

           
        }
    }
}

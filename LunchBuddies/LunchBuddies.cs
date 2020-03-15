using System;
using System.Collections.Generic;
using System.Text;


namespace LunchBuddies
{
    class LunchBuddy
    {
        
        public string FirstName { get; set;  } 
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($@"{FirstName} {LastName} is having lunch at {restaurant.Name}");
            return restaurant.Name;
        }

        public void Eat(string food)
        {
            Console.WriteLine($@"{FirstName} {LastName} ate {food} at the office today.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($@"{FirstName} {LastName} is eating at {restaurant.Name} with his lunchbuddies");

            foreach (var lunchBud in companions)
            {
                Console.WriteLine($"{lunchBud.FirstName}");
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
                Console.WriteLine($@"{FirstName} {LastName} is eating {food} at {restaurant.Name} with his lunchbuddies");
            foreach (var lunchBud in companions)
            {
                Console.WriteLine($"{lunchBud.FirstName}");
            }
        }
    }
}

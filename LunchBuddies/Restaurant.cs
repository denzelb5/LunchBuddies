using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public List<string> Restaurants = new List<string> { "Frothy Monkey", "Thai Esane", "Burger Up", "Mockingbird" };
        public string Name { get; set; }

        public Restaurant()
        {
            var Random = new Random();
            int Index = Random.Next(Restaurants.Count);
            Name = Restaurants[Index];
        }
    }
}

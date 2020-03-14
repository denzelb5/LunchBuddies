using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddies
    {
        public string FirstName { get; set;  } 
        public string LastName { get; set; }
        public LunchBuddies(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

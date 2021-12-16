using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatUnitTest
{
    public class Account
    {
        public string Owner { get; private set; }
        public Card Card { get; set; }

        public Account(string owner, Card card)
        {
            Owner = owner;
            Card = card;
        }
    }
}

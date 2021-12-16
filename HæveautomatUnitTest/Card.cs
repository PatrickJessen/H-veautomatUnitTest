using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatUnitTest
{
    public class Card
    {
        public int CardNumber { get; private set; }
        public string Name { get; private set; }
        public int PinCode { get; private set; }
        public decimal Balance { get; set; }

        public Card(int cardNumber, string name, int pinCode, decimal balance)
        {
            CardNumber = cardNumber;
            Name = name;
            PinCode = pinCode;
            Balance = balance;
        }
    }
}

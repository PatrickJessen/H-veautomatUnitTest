using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatUnitTest
{
    public class Automat
    {
        private Card card;
        private Validation validation;
        private int inputPinCode;

        public Automat()
        {
            validation = new Validation();
        }

        public Card InsertCard(Card card)
        {
            this.card = card;
            return card;
        }

        public void TypePinCode(int input)
        {
            inputPinCode = input;
        }

        public decimal Withdraw(decimal balance)
        {
            if (validation.IsPinCodeValid(card.PinCode, inputPinCode) && card.Balance >= balance)
            {
                card.Balance -= balance;
                return balance;
            }
            return -1;
        }
    }
}

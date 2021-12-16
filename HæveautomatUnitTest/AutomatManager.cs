using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatUnitTest
{
    public class AutomatManager
    {
        private Account account;
        private Automat automat;
        public AutomatManager()
        {
            automat = new Automat();
        }

        public void ShowWithdraw()
        {
            InsertCard();
            Console.WriteLine("Type pin code");
            int input = int.Parse(Console.ReadLine());
            if (automat.Withdraw(input) != -1)
            {
                Console.WriteLine($"Your successfully withdrawed {automat.Withdraw(input)} from your bank account");
                return;
            }
            Console.WriteLine("Your input did not match the pin code!");
        }

        private void InsertCard()
        {

            account = new Account("Patrick", automat.InsertCard(new Card(1234, "Patrick", 4444, 8000)));
        }
    }
}

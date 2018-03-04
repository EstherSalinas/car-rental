using System;

namespace CsIntro
{
    class Encapsulation
    {
        public void EncapsulationSample()
        {
            // We will use the class below in this file and calls to it to show it
            var account = new BankAccount();

            // The line below is commented out because balance private field is hidden and cannot be manipulated form the outside, only through the property and method that encapsulate it
            // Console.WriteLine(account.balance);

            Console.WriteLine("Putting 1500 into the account.");
            account.PutMoney(1500);

            Console.WriteLine("The new balance is {0}", account.Balance);
        }

        class BankAccount
        {
            private decimal balance;

            public decimal Balance => this.balance;

            public void PutMoney(decimal amount)
            {
                this.balance += amount;
            }
        }
    }
}

namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using BankAccounts.Base_Classes;

    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public List<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.accounts = value;
            }
        }

        public void AddAccount(Account acc)
        {
            this.accounts.Add(acc);
        }

        public void RemoveAccount(Account acc)
        {
            this.accounts.Remove(acc);
        }
    }
}

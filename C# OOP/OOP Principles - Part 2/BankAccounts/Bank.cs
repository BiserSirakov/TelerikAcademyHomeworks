namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BankAccounts.Base_Classes;

    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public Account this[int index]
        {
            get
            {
                return this.Accounts[index];
            }
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (Account account in this.accounts)
            {
                result.Append(account.ToString() + Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
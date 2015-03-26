namespace BankAccounts.Base_Classes
{
    using System;
    using BankAccounts.Interfaces;

    public abstract class Account : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.interestRate = value;
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(decimal months)
        {
            return 0;
        }
    }
}
namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Base_Classes;
    using BankAccounts.Interfaces;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interest) 
            : base(customer, balance, interest)
        {

        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return months * (this.InterestRate / 100) * this.Balance;
            }
        }

        public override string ToString()
        {
            return string.Format("Deposit Account : {0}, Balance : {1}", this.Customer.Name, this.Balance);
        }
    }
}

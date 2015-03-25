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
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
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
    }
}

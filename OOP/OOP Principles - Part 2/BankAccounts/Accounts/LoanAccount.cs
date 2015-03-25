namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Base_Classes;
    using BankAccounts.Customers;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Individual)
            {
                if (months >= 3)
                {
                    months = -3;
                }
            }
            else
            {
                if (months >= 2)
                {
                    months -= 2;
                }
            }

            return months * (this.InterestRate / 100) * this.Balance;
        }
    }
}

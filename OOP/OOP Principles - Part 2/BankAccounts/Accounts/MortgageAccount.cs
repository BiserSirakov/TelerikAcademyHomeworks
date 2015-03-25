namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Base_Classes;
    using BankAccounts.Customers;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interest) 
            : base(customer, balance, interest)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Company)
            {
                return months * ((this.InterestRate / 100) / 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
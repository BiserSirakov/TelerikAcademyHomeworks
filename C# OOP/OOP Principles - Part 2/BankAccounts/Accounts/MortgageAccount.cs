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

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer is Company)
            {
                if (months < 12)
                {
                    months *= 0.5M; // if the months are 2 times less, than the result will be 2 times less too
                }
            }
            else if (this.Customer is Individual)
            {
                if (months < 6)
                {
                    months = 0;
                }
            }

            return months * (this.InterestRate / 100) * this.Balance; 
        }

        public override string ToString()
        {
            return string.Format("Mortgage Account : {0}, Balance : {1}", this.Customer.Name, this.Balance);
        }
    }
}
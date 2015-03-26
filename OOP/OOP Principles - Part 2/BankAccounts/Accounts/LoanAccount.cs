﻿namespace BankAccounts.Accounts
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

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer is Individual)
            {
                if (months < 3)
                {
                    months = 0;
                }
            }
            else if (this.Customer is Company)
            {
                if (months < 2)
                {
                    months = 0;
                }
            }

            return months * (this.InterestRate / 100) * this.Balance;
        }

        public override string ToString()
        {
            return string.Format("Loan Account : {0}, Balance : {1}", this.Customer.Name, this.Balance);
        }
    }
}

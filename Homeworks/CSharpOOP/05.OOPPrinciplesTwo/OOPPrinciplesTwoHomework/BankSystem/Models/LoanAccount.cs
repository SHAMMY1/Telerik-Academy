namespace BankSystem.Models
{
    using System;
    using BankSystem.Interfaces;
    using BankSystem.Enumerations;

    public class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate) { }

        public override void WithDraw(decimal money)
        {
            throw new InvalidOperationException("Can not withdraw from loan acount");
        }

        public override double CalculateInterest(uint months)
        {
            if (months <= (this.Customer.Type == CustomerType.Individual ? 3 : 2))
            {
                return 0;
            }
            return base.CalculateInterest(months - (uint)(this.Customer.Type == CustomerType.Individual ? 3 : 2));
        }
    }
}

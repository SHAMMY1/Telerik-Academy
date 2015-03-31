namespace BankSystem.Models
{
    using System;
    using BankSystem.Interfaces;
    using BankSystem.Enumerations;

    public class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate) { }

        public override void WithDraw(decimal money)
        {
            throw new InvalidOperationException("Can not withdraw from mortgage acount");
        }

        public override double CalculateInterest(uint months)
        {
            if (months <= (this.Customer.Type == CustomerType.Individual ? 6 : 12))
            {
                return base.CalculateInterest(months) / 2;
            }
            return (base.CalculateInterest((uint)(this.Customer.Type == CustomerType.Individual ? 6 : 12))) + base.CalculateInterest(months - (uint)(this.Customer.Type == CustomerType.Individual ? 6 : 12));
        }
	}
}

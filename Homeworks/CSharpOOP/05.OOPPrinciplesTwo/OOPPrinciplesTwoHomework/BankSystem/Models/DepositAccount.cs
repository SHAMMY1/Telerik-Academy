namespace BankSystem.Models
{
    using BankSystem.Interfaces;


	class DepositAccount : Account
	{
        public DepositAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate) { }

        public override double CalculateInterest(uint months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
	}
}

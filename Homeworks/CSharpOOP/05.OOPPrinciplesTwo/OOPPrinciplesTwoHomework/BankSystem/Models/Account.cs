namespace BankSystem.Models
{
	using BankSystem.Interfaces;

	public abstract class Account : IAccount
	{
		private ICustomer customer;
		private  decimal balance;
		private double interestRate;

		public ICustomer Customer
		{
			get 
			{ 
				return this.customer; 
			}

			private set
			{
				this.customer = value;
			}
		}

		public decimal Balance
		{
			get 
			{
				return this.balance;
			}

			private set
			{
				this.balance = value;
			}

		}

		public double InterestRate
		{
			get 
			{ 
				return this.interestRate; 
			}

			private set
			{
				this.interestRate = value;
			}
		}

		public Account(ICustomer customer, decimal balance, double interestRate)
		{
			this.Customer = customer;
			this.Balance = balance;
			this.InterestRate = interestRate;
            customer.AddAccount(this);
		}

		public virtual double CalculateInterest(uint months)
		{
			return this.InterestRate * months;
		}

		public virtual void Deposit(decimal money)
		{
			this.Balance += money;
		}

		public virtual void WithDraw(decimal money)
		{
			this.Balance -= money;
		}
	}
}

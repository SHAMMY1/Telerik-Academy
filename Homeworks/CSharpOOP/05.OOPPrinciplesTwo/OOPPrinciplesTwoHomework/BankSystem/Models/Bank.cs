namespace BankSystem.Models
{
	using System.Collections.Generic;
	using BankSystem.Interfaces;

	public class Bank : IBank
	{
		private string name;
		private ICollection<IAccount> accounts;
		private ICollection<ICustomer> customers;

		public string Name
		{
			get 
			{ 
				return this.name; 
			}

			private set
			{
				this.name = value;
			}
		}

		public List<IAccount> Accounts
		{
			get 
			{ 
				return new List<IAccount>(this.accounts); 
			}

			private set
			{
				this.accounts = value;
			}
		}

		public List<ICustomer> Customers
		{
			get 
			{ 
				return new List<ICustomer>(this.customers); 
			}
		}

		public void AddAccount(IAccount account)
		{
			this.accounts.Add(account);
		}

		public void RemoveAccount(IAccount account)
		{
			this.accounts.Remove(account);
		}

		public void AddCustomer(ICustomer customer)
		{
			this.customers.Add(customer);
		}

		public void RemoveCustomer(ICustomer customer)
		{
			this.customers.Remove(customer);
		}
	}
}

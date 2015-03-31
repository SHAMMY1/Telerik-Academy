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

		public ICollection<IAccount> Accounts
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

		public ICollection<ICustomer> Customers
		{
			get 
			{ 
				return new List<ICustomer>(this.customers); 
			}

            private set
            {
                this.customers = value;
            }
		}

        public Bank(string name)
        {
            this.Name = name;
            this.Customers = new List<ICustomer>();
            this.Accounts = new List<IAccount>();
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

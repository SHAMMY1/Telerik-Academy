using System.Collections.Generic;
namespace BankSystem.Interfaces
{
	public interface IBank
	{
		string Name { get; }

		ICollection<IAccount> Accounts { get; }

		ICollection<ICustomer> Customers { get; }

		void AddAccount(IAccount Account);

		void RemoveAccount(IAccount Account);

		void AddCustomer(ICustomer customer);

		void RemoveCustomer(ICustomer customer);
	}
}

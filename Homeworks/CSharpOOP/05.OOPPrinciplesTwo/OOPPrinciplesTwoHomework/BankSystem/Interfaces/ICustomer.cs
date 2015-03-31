using BankSystem.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem.Interfaces
{
	class ICustomer
	{
		string Name { get; }

		CustomerType Type { get; }

		ICollection<IAccount> Acounts { get; }

		void AddAccount(IAccount Account);

		void RemoveAccount(IAccount Account);
	}
}

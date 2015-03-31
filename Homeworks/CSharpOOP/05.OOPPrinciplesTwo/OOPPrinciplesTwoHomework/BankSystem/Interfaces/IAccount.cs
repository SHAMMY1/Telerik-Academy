namespace BankSystem.Interfaces
{
	public interface IAccount
	{
		ICustomer Customer { get; }

		decimal Balance { get; }

		double InterestRate { get; }

		double CalculateInterest(uint months);

		void Deposit(decimal money);

		void WithDraw(decimal money);
	}
}

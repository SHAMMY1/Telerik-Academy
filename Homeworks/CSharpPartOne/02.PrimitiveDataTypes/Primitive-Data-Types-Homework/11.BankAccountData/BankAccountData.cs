//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using 
//the appropriate data types and descriptive names.

using System;

class BankAccountData
{
	static void Main()
	{
		string task = "Problem 11. Bank Account Data\n\nA bank account has a holder name (first name, middle name and last name),\navailable amount of money (balance), bank name, IBAN, 3 credit card numbers\nassociated with the account.Declare the variables needed to keep the\ninformation for a single bank account using the appropriate data types and\ndescriptive names.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string holderFirstName = "Pesho";
		string holderMiddleName = "Ivanov";
		string holderLastName = "Goshov";

		decimal moneyBalance = 1000000.01M;

		string bankName = "Corporate Commercial Bank";

		string iBAN = "BG80 BNBG 9661 1020 3456 78";

		int firstCreditCardNumber = 893374576;
		int secondCreditCardNumber = 192394876;
		int thirdCreditCardNumber = 983384576;

		Console.WriteLine("Holder name: {0}", holderFirstName + " " + holderMiddleName + " " + holderLastName);
		Console.WriteLine("Balance: {0}", moneyBalance);
		Console.WriteLine("Bank name: {0}", bankName);
		Console.WriteLine("IBAN: {0}", iBAN);
		Console.WriteLine("Creditcards numbers: {0}", firstCreditCardNumber + ", " + secondCreditCardNumber + ", " + thirdCreditCardNumber);

	}
}

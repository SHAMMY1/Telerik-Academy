namespace GSMCallHistoryTest
{
	using System;
	using GSMInfo;

	class GSMCallHistoryTest
	{
		public static void Main()
		{
			GSM gsm = new GSM("Lumia", "Nokia");

			gsm.AddCall(new Call("555555555", 100));
			gsm.AddCall(new Call("666666666", 200));
			gsm.AddCall(new Call("777777777", 300));

			gsm.PrintHistory();

			Console.WriteLine("\nTotal prise: {0}", gsm.TotalPrice(0.37));

			Call longest = new Call(gsm.CallHistory[0]);

			foreach (var call in gsm.CallHistory)
			{
				if (longest.Duration < call.Duration)
				{
					longest = new Call(call);
				}
			}

			gsm.DeleteCall(longest);

			Console.WriteLine("\nTotal price without longest: {0}", gsm.TotalPrice(0.37));

			gsm.ClearHistory();

			gsm.PrintHistory();
		}

	}
}

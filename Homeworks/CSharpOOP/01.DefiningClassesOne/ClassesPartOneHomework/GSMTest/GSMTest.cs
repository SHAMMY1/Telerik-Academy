namespace GSMTest
{
	using System;
	using GSMInfo;
	using GSMInfo.Components;
	using GSMInfo.Enumerations;

	class GSMTest
	{
		static void Main()
		{


			GSM[] mobiles = new GSM[] {
				new GSM("Lumia","Nokia",300.00m,"Pesho",new Battery("NokiaBattery", 10,3,BatteryType.NiMH),new Display(4,16000000)),
				new GSM("Xperia","Sony",500.00m,"Pesho",new Battery("SonyBattery", 20,5,BatteryType.Li_Ion),new Display(4.5 ,16000000)),
				new GSM("Galaxy","Samsung",800.00m,"Pesho",new Battery("SamsungBattery", 30,10,BatteryType.NiMH),new Display(5.5, 16000000))
			};

			foreach (var gsm in mobiles)
			{
				Console.WriteLine("{0}\n", gsm);
			}

			Console.WriteLine(GSM.IPhone4S1);

		}
	}
}

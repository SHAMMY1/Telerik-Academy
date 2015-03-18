namespace GSMInfo
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Linq;
	using GSMInfo.Components;
    using GSMInfo.Enumerations;

	public class GSM
	{
		#region Static fields

		private static GSM IPhone4S = new GSM("IPhone4S", "Apple", 1000m, "Me", new Battery("AppleBatery", 20, 5, BatteryType.Li_Poly), new Display(4, 16000000));

		public static GSM IPhone4S1
		{
			get { return GSM.IPhone4S; }

		}

		#endregion

		#region Fields

		private string model;

		private string manufacturer;

		private decimal? price;

		private string owner;

		private Battery battery;

		private Display display;

		private List<Call> callHistory;

		#endregion

		#region Constructors

		public GSM(string model, string manufacturer)
		{
			this.Manufacturer = manufacturer;
			this.Model = model;
			this.CallHistory = new List<Call>();
		}

		public GSM(string model, string manufacturer, decimal price)
			: this(model, manufacturer)
		{
			this.Price = price;
		}

		public GSM(string model, string manufacturer, decimal price, string owner)
			: this(model, manufacturer, price)
		{
			this.Owner = owner;
		}

		public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
			: this(model, manufacturer, price, owner)
		{
			this.Battery = battery;
		}

		public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
			: this(model, manufacturer, price, owner, battery)
		{
			this.Display = display;
		}

		public GSM(GSM gsm)
		{
			this.Model = gsm.Model;
			this.Manufacturer = gsm.Manufacturer;

			if (gsm.price != null)
			{
				this.Price = gsm.Price;
			}

			if (gsm.Owner != null)
			{
				this.Owner = gsm.Owner;
			}

			if (gsm.Battery == null)
			{
				this.Battery = gsm.Battery;
			}

			if (gsm.Display != null)
			{
				this.Display = gsm.Display;
			}
		}
		#endregion

		#region Properties

		public string Model
		{
			get
			{
				return this.model;
			}

			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Model can not be null or empty!");
				}
				this.model = value;
			}
		}

		public string Manufacturer
		{
			get
			{
				return this.manufacturer;
			}

			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Manufacturer can not be null or empty!");
				}
				this.manufacturer = value;
			}
		}

		public decimal? Price
		{
			get
			{
				return this.price;
			}

			private set
			{
				if (value < 0)
				{
					throw new ArgumentException("Price can not be less than zero!");
				}

				this.price = value;
			}
		}

		public string Owner
		{
			get
			{
				return this.owner;
			}

			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Owner can not be null or empty!");
				}
				this.owner = value;
			}
		}

		public Battery Battery
		{
			get
			{
				return this.battery;
			}

			private set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Battery","Battery cannot be null!");
				}

				this.battery = value;
			}
		}

		public Display Display
		{
			get
			{
				return this.display;
			}

			private set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Display","Display cannot be null!");
				}

				this.display = value;
			}
		}

		public List<Call> CallHistory
		{
			get 
			{ 
				return this.callHistory.ConvertAll(c => new Call(c)); 
			}
			private set 
			{
				callHistory = value; 
			}
		}

		#endregion

		#region Methods
		public void AddCall(Call call)
		{
			this.callHistory.Add(call);
		}

		public void DeleteCall(Call call)
		{
			this.callHistory.Remove(call);
		}

		public void ClearHistory()
		{
			this.callHistory = new List<Call>();
		}

		public void PrintHistory()
		{
			if (this.callHistory.Count == 0)
			{
				Console.WriteLine("No calls");
			}
			else
			{
				StringBuilder calls = new StringBuilder();

				foreach (var call in this.callHistory)
				{
					calls.AppendLine(call.ToString());
				}

				Console.WriteLine(calls.ToString().Trim());
			}
		}

		public double TotalPrice(double price)
		{
			double pricePerSec = price / 60;
			double totalPrice = 0;

			foreach (var call in this.callHistory)
			{
				totalPrice += call.Duration * pricePerSec;
			}

			return totalPrice;
		}

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();

			result.Append(string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery:\n{4}\nDisplay:\n{5}",
				this.Model, 
				this.Manufacturer,
				this.Price == null ? "N/A" : this.Price.ToString() + "$",
				this.Owner == null ? "N/A" : this.Owner.ToString(),
				this.Battery == null ? "N/A" : this.Battery.ToString(),
				this.Display == null ? "N/A" : this.Display.ToString()
				));

			return result.ToString();
		}

		#endregion
	}
}

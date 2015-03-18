namespace GSMInfo.Components
{
	using GSMInfo.Enumerations;
	using System;

	public class Battery
	{
		#region Fields

		private string model;

		private int hoursIdle;

		private int hoursTalk;

		#endregion

		#region Constructors

		public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
		{
			this.Model = model;
			this.HoursIdle = hoursIdle;
			this.HoursTalk = hoursTalk;
			this.BatteryType = batteryType;
		}

		public Battery(Battery battery)
		{
			this.Model = battery.Model;
			this.HoursIdle = battery.HoursIdle;
			this.HoursTalk = battery.HoursTalk;
			this.BatteryType = battery.BatteryType;
		}

		#endregion

		#region Properties

		public string Model
		{
			get 
			{ 
				return this.model; 
			}

			set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Model can not be null or empty!");
				}
				this.model = value; 
			}
		}

		public int HoursIdle
		{
			get 
			{ 
				return this.hoursIdle; 
			}

			set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Idle hourse can not be less than zero!");
				}

				this.hoursIdle = value; 
			}
		}

		public int HoursTalk
		{
			get 
			{ 
				return this.hoursTalk; 
			}

			set 
			{ 
				if (value < 0)
				{
					throw new ArgumentException("Talk hourse can not be less than zero!");
				}

				this.hoursTalk = value; 
			}
		}

		public BatteryType BatteryType { get; private set; }


		#endregion

		#region Methods

		public override string ToString()
		{
			return string.Format("Model: {0}\nHours idle: {1}\nHours talk: {2}\nType: {3}",this.Model, this.HoursIdle + "h", this.HoursTalk + "h", this.BatteryType);
		}

		#endregion
	}
}

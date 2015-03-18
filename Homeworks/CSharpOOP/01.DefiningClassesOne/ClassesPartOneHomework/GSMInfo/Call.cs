namespace GSMInfo
{
	using System;

	public class Call
	{
		private string number;
		private int duration;

		public Call(string number, int duration)
		{
			this.DateAndTime = DateTime.Now;
			this.Number = number;
			this.Duration = duration;
		}
		public Call(Call call)
		{
			this.DateAndTime = call.DateAndTime;
			this.Number = call.Number;
			this.Duration = call.Duration;
		}

		public static bool operator ==(Call call1, Call call2)
		{
			if (call1.DateAndTime == call2.DateAndTime)
			{
				if (call1.Number == call2.Number)
				{
					if (call1.Duration == call2.Duration)
					{
						return true;
					}
				}
			}

			return false;
		}
		public static bool operator !=(Call call1, Call call2)
		{
			return !(call1 == call2);
		}

		public DateTime DateAndTime { get; private set; }

		public string Number
		{
			get
			{
				return this.number;
			}

			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Dialled number cannot be null or empty!");
				}

				this.number = value;
			}
		}

		public int Duration
		{
			get
			{
				return this.duration;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Duration cannot be less than zero!");
				}

				this.duration = value;
			}
		}

		public override string ToString()
		{
			return string.Format("Date and time: {0}\nNumber: {1}\nDuration: {2}", this.DateAndTime, this.Number, this.Duration);
		}

		public override bool Equals(object obj)
		{
			return this == obj as Call;
		}
	}
}

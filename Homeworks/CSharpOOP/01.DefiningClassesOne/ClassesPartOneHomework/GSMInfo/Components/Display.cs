namespace GSMInfo.Components
{
	using System;

	public class Display
	{
		#region Fields

		private double size;

		private long colors;

		#endregion

		#region Constructors

		public Display(double size, long colors)
		{
			this.Size = size;
			this.Colors = colors;
		}

		public Display(Display display)
		{
			this.Size = display.size;
			this.Colors = display.Colors;
		}

		#endregion

		#region Properties

		public double Size
		{
			get 
			{ 
				return this.size; 
			}

			set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Size can not be less than zero!");
				}

				this.size = value; 
			}
		}

		public long Colors
		{
			get 
			{ 
				return this.colors; 
			}
			set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Colors can not be less than zero!");
				}
				this.colors = value; 
			}
		}

		#endregion

		#region Methods

		public override string ToString()
		{
			return string.Format("Size: {0}\nColors: {1}", this.Size, this.Colors);
		}

		#endregion
	}
}

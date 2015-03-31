namespace Shapes.Models
{
	using Shapes.Interfaces;

	public abstract class Shape : IShape
	{
		private double width;
		private double height;

		public double Width
		{
			get 
			{ 
				return this.width; 
			}
			private set 
			{
				this.width = value;
			}
		}

		public double Height
		{
			get 
			{ 
				return this.height; 
			}
			private set
			{
				this.height = value;
			}
		}

		public Shape(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		public abstract double CalculateSurface();
	}
}

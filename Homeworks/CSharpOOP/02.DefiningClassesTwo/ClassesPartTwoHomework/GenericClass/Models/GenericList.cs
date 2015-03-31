namespace GenericClass.Models
{
	using System;

	public class GenericList<T>
	{
		private T[] data;

		private int lastIndex = 0;

		public GenericList(int initialCapacity)
		{
			this.data = new T[initialCapacity];
		}

		public void Add(T element)
		{
			if (this.lastIndex >= this.data.Length) 
				Resize();

			this.data[lastIndex] = element;
			lastIndex++;
		}

		public T this[int index]
		{
			get 
			{
				if (index >= lastIndex)
				{
					throw new ArgumentOutOfRangeException("index", "Argument is out of range!");
				}
				return this.data[index]; 
			}
			private set 
			{
				if (this.lastIndex >= this.data.Length)
					Resize();

				this.data[index] = value; 

			}
		}

		public void RemoveAt(int index)
		{
			for (int i = index; i < lastIndex-1; i++)
			{
				this.data[i] = this.data[i + 1];
			}

			lastIndex--;
		}

		public void AddAt(int index, T value)
		{
			if (this.lastIndex >= this.data.Length)
				Resize();

			for (int i = this.lastIndex; i > index; i--)
			{
				this.data[i] = this.data[i - 1];
			}

			this.data[index] = value;

			lastIndex++;
		}
		public void Clear()
		{
			this.data = new T[this.data.Length];
			this.lastIndex = 0;
		}

		private void Resize()
		{
			var newData = new T[this.data.Length * 2];

			for (int i = 0; i < this.data.Length; i++)
			{
				newData[i] = this.data[i];
			}

			this.data = newData;
		}
	}
}

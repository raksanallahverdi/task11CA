using System;
namespace Task12
{
	public class Product
	{
		public string Name { get; set; }
		public int Price { get; set; }
		public Type Type { get; set; }
		
		public Product(string name,int price, Type type)
		{
			Name = name;
			Price = price;
			Type = type;
		}
		public void GetDetails()
		{
			Console.WriteLine($"{Name} {Price} {Type}");
		}

		
	}
}


using System;
namespace Task12
{
	public class ProductCatalog
	{
		private Product[] products;
        public Product[] Products { get=>products;}
		public ProductCatalog()
		{
            products = new Product[0];
        }

		public void Add(Product Product)
		{
			Array.Resize(ref products, products.Length + 1);
			products[products.Length - 1] = Product;

		}

		public void GetAll()
		{
			foreach(var product in products)
			{
				product.GetDetails();
			}
		}

        public void GetAllProductsByType(Type requiredType)
		{
            foreach (var product in products)
            {
                if (requiredType == product.Type)
				{
                    product.GetDetails();

                }
            }

        }
    }
}


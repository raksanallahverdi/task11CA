
using System;
namespace Task12
{


    public static class Program
    {
        public static void Main()
        {
            ProductCatalog catalog1 = new ProductCatalog();
            Product phone = new Product("Iphone", 2000, Type.Electronics);
            Product dress = new Product("Charles & Keith", 700, Type.Clothing);
            catalog1.Add(phone);
            catalog1.Add(dress);
            catalog1.GetAll();
            catalog1.GetAllProductsByType(Type.Electronics);
            Console.ReadLine();



        }
    }

}


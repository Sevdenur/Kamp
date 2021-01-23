using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.Categoryid = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {id=2, Categoryid=5, UnitInStock=5,
                ProductName ="Kalem", UnitPrice=35};
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
        }
    }
}

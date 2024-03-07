using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
 
        class Product
        {
            public int ProductId;
            public string ProductName;
            public double Price;

            public Product(int productId, string productName, double price)
            {
                ProductId = productId;
                ProductName = productName;
                Price = price;
            }
        }

        class Prod
        {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the product you want to add : ");
            int prod = int.Parse(Console.ReadLine());
            Product[] products = new Product[prod];
                for (int i = 0; i < prod; i++)
                {
                    Console.WriteLine($"Enter details for product {i + 1}:");
                    Console.Write("Product ID: ");
                    int productId = int.Parse(Console.ReadLine());
                    Console.Write("Product Name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    products[i] = new Product(productId, productName, price);
                }


                Array.Sort(products, (p1, p2) => p1.Price.CompareTo(p2.Price));


                Console.WriteLine("\nSorted Products based on Price:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
                }
                Console.ReadLine();
            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWork
{
    internal class Price
    {
        public static string[] products = new string[3] { "Apple", "Banana", "Orange" };

        public string nameOfShop = "Fruti";

        public double[] priceofproducts = new double[3] { 50.99, 61.99, 71.99 };
        public string value = "grn";

        public void Method()
        {
            Console.WriteLine($"\t\t\t\t\t{nameOfShop} :)");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\tOur products:");
            Console.WriteLine($"1.{products[0]}\n2.{products[1]}\n3.{products[2]}");
            Console.WriteLine();
            Console.WriteLine("Choose the name of product");
            string nameofproducts = Console.ReadLine();

            if (nameofproducts == products[0])
            {
                Console.WriteLine($"The price for {products[0]} is {priceofproducts[0]} {value}");
            }
            else if (nameofproducts == products[1])
            {
                Console.WriteLine($"The price for {products[1]} is {priceofproducts[1]} {value}");
            }
            else if (nameofproducts == products[2])
            {
                Console.WriteLine($"The price for {products[2]}  is  {priceofproducts[2]} {value}");
            }
            else
            {
                Console.WriteLine("Incorrect name of product");
            }
        }
    }
}

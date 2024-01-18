using System;
using System.Globalization;
using System.Collections.Generic;
using Product_NewImporterOrUsed.Entities;

namespace Product_NewImporterOrUsed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product {i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'c')
                {
                    Product product = new Product(name, price);
                    list.Add(product);
                }

                if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProuct(name, price, date);
                    list.Add(product);
                    //list.Add(new UsedProduct (name, price, date)); !!alternative!!
                }

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new ImportedProduct(name, price, fee);
                    list.Add(product);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
                
            }
        }
    }
}
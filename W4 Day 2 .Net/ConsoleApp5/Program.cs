using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product { Name = "Pen", Price = 50 },
            new Product { Name = "Notebook", Price = 120 },
            new Product { Name = "Bag", Price = 800 },
            new Product { Name = "Shoes", Price = 1500 },
            new Product { Name = "Bottle", Price = 250 }
        };

        Console.WriteLine("Products with price greater than 200:");

        foreach (Product p in products)
        {
            if (p.Price > 200)
            {
                Console.WriteLine(p.Name + " - " + p.Price);
            }
        }
    }
}
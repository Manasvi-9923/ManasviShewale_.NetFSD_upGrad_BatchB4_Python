
using System;
using System.Linq;

namespace LinqCodeTemplate
{
    internal class Problem1
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            // 1 FMCG Products
            Console.WriteLine("1. FMCG Products");
            var q1 = products.Where(p => p.ProCategory == "FMCG");
            foreach (var item in q1)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }

            // 2 Grain Products
            Console.WriteLine("\n2. Grain Products");
            var q2 = products.Where(p => p.ProCategory == "Grain");
            foreach (var item in q2)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }

            // 3 Sort by Product Code
            Console.WriteLine("\n3. Sort by Product Code");
            var q3 = products.OrderBy(p => p.ProCode);
            foreach (var item in q3)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}");
            }

            // 4 Sort by Category
            Console.WriteLine("\n4. Sort by Category");
            var q4 = products.OrderBy(p => p.ProCategory);
            foreach (var item in q4)
            {
                Console.WriteLine($"{item.ProName}\t{item.ProCategory}");
            }

            // 5 Sort by MRP Ascending
            Console.WriteLine("\n5. Sort by MRP Ascending");
            var q5 = products.OrderBy(p => p.ProMrp);
            foreach (var item in q5)
            {
                Console.WriteLine($"{item.ProName}\t{item.ProMrp}");
            }

            // 6 Sort by MRP Descending
            Console.WriteLine("\n6. Sort by MRP Descending");
            var q6 = products.OrderByDescending(p => p.ProMrp);
            foreach (var item in q6)
            {
                Console.WriteLine($"{item.ProName}\t{item.ProMrp}");
            }

            // 7 Group by Category
            Console.WriteLine("\n7. Group by Category");
            var q7 = products.GroupBy(p => p.ProCategory);
            foreach (var group in q7)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item.ProName);
                }
            }

            // 8 Group by MRP
            Console.WriteLine("\n8. Group by MRP");
            var q8 = products.GroupBy(p => p.ProMrp);
            foreach (var group in q8)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item.ProName);
                }
            }

            // 9 Highest price FMCG
            Console.WriteLine("\n9. Highest Price FMCG");
            var q9 = products.Where(p => p.ProCategory == "FMCG")
                             .OrderByDescending(p => p.ProMrp)
                             .First();
            Console.WriteLine($"{q9.ProName} {q9.ProMrp}");

            // 10 Total Products
            Console.WriteLine("\n10. Total Products");
            Console.WriteLine(products.Count());

            // 11 FMCG Count
            Console.WriteLine("\n11. FMCG Count");
            Console.WriteLine(products.Count(p => p.ProCategory == "FMCG"));

            // 12 Max Price
            Console.WriteLine("\n12. Max Price");
            Console.WriteLine(products.Max(p => p.ProMrp));

            // 13 Min Price
            Console.WriteLine("\n13. Min Price");
            Console.WriteLine(products.Min(p => p.ProMrp));

            // 14 All products below 30
            Console.WriteLine("\n14. All products below 30");
            Console.WriteLine(products.All(p => p.ProMrp < 30));

            // 15 Any product below 30
            Console.WriteLine("\n15. Any product below 30");
            Console.WriteLine(products.Any(p => p.ProMrp < 30));

            Console.ReadLine();
        }
    }
}
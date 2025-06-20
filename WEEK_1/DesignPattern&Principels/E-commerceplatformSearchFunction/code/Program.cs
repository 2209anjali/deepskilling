using System;
using System.Diagnostics;

namespace EcommerceSearch {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category) {
            Id = id;
            Name = name;
            Category = category;
        }

        public override string ToString() {
            return $"ID: {Id}, Name: {Name}, Category: {Category}";
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" E-Commerce Search System");
            Console.WriteLine("===================================");

            Product[] products = {
                new Product(101, "Wireless Mouse", "Electronics"),
                new Product(205, "Cotton T-Shirt", "Clothing"),
                new Product(302, "Coffee Mug", "Kitchen"),
                new Product(103, "Bluetooth Headphones", "Electronics"),
                new Product(503, "Notebook", "Stationery"),
                new Product(307, "Frying Pan", "Kitchen"),
                new Product(508, "Pen", "Stationery"),
                new Product(105, "Laptop", "Electronics"),
                new Product(208, "Silk Saree", "Clothing"),
                new Product(207, "Scarf", "Clothing"),
                new Product(305, "Dinner set", "Kitchen"),
                new Product(104, "IPad", "Electronics"),
                new Product(505, "Pencil Box", "Stationery"),
                new Product(202, "Cap", "Clothing")
            };

            Product[] sortedProducts = (Product[])products.Clone();
            Array.Sort(sortedProducts, (x, y) => x.Id.CompareTo(y.Id));

            Console.WriteLine("\n Available Products:");
            foreach (var product in sortedProducts) {
                Console.WriteLine(product);
            }

            Console.Write("\n Search:(enter PRODUCT ID)");
            if (int.TryParse(Console.ReadLine(), out int searchId)) {
 
                Console.WriteLine("\n Linear Search Results:");
                var linearResult = LinearSearch(products, searchId);
                ShowResult(linearResult);

                Console.WriteLine("\n Binary Search Results:");
                var binaryResult = BinarySearch(sortedProducts, searchId);
                ShowResult(binaryResult);

                ComparePerformance(products, sortedProducts, searchId);
            }
            else {
                Console.WriteLine("you entered a Invalid input. Please enter a number.");
            }
        }

        // Simple linear search
        static Product LinearSearch(Product[] products, int id) {
            foreach (var product in products) {
                if (product.Id == id) {
                    return product;
                }
            }
            return null;
        }


        static Product BinarySearch(Product[] products, int id) {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right) {
                int middle = left + (right - left) / 2;

                if (products[middle].Id == id) {
                    return products[middle];
                }

                if (products[middle].Id < id) {
                    left = middle + 1;
                }
                else {
                    right = middle - 1;
                }
            }

            return null;
        }

        static void ShowResult(Product result) {
            if (result != null) {
                Console.WriteLine($"✅ Found: {result}");
            }
            else {
                Console.WriteLine("❌ Product not found");
            }
        }

        // Compare search speeds
        static void ComparePerformance(Product[] normalArray, Product[] sortedArray, int id) {
            Console.WriteLine("\n⏱️ Performance Comparison:");

            Stopwatch timer = new Stopwatch();

            timer.Start();
            LinearSearch(normalArray, id);
            timer.Stop();
            Console.WriteLine($"Time taken by Linear Search: {timer.ElapsedTicks} ticks");

            timer.Restart();
            BinarySearch(sortedArray, id);
            timer.Stop();
            Console.WriteLine($"Time taken by Binary Search: {timer.ElapsedTicks} ticks");

            Console.WriteLine("\n Here is Algorithm Analysis:\n");
            Console.WriteLine("- Linear Search: Checks each item one by one (O(n) complexity)");
            Console.WriteLine("- Binary Search: Splits the search area in half each time (O(log n) complexity)");
            Console.WriteLine("\nFor large product databases, binary search is much faster!");
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        public class Product {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Product(string name, decimal price) {
                Name = name;
                Price = price;
            }
        }

        static void Main(string[] args)
        {
            List<int> numbers_list_1 = new List<int> { 0, 4, 2, -5, 9, 4};
            List<int> numbers_list_2 = new List<int> { 0, 1, -5, 1, 10, 0};
            List<Product> products_list = new List<Product> {
                new Product("zebra", 25),
                new Product("airplane", 30),
                new Product("bicycle", 30),
                new Product("cheddar", 25),
                new Product("airplane", 10)
            };

            // restriction operator Where
            var greaterThan5 = numbers_list_1.Where(x => x > 5).ToList();
            Console.Write("numbers_list_1.Where(x => x > 5) -> ");
            printList(greaterThan5);

            // projection operator Select
            var squares = numbers_list_1.Select(x => x * x).ToList();
            Console.Write("numbers_list_1.Select(x => x * x) -> ");
            printList(squares);

            var productsNames = products_list.Select(x => x.Name).ToList();
            Console.Write("products_list.Select(x => x.Name) -> ");
            printList(productsNames);

            // We can execute LINQ methods in linear order
            var squaresOfGreaterThan5 = numbers_list_1.Where(x => x > 5).Select(x => x * x).ToList();
            Console.Write("numbers_list_1.Where(x => x > 5).Select(x => x * x) -> ");
            printList(squaresOfGreaterThan5);

            /*
                Partitioning operators
             */

            // Take
            var take3 = numbers_list_1.Take(3).ToList();
            Console.Write("numbers_list_1.Take(3) -> ");
            printList(take3);

            // Skip
            var skip3 = numbers_list_1.Skip(3).ToList();
            Console.Write("numbers_list_1.Skip(3) -> ");
            printList(skip3);

            // TakeWhile
            var takeWhile = numbers_list_1.TakeWhile(x => x < 2).ToList();
            Console.Write("numbers_list_1.TakeWhile(x => x < 2) -> ");
            printList(takeWhile);

            // SkipWhile
            var skipWhile = numbers_list_1.SkipWhile(x => x < 2).ToList();
            Console.Write("numbers_list_1.SkipWhile(x => x < 2) -> ");
            printList(skipWhile);
            
            /*
                Ordering operators
             */
            
            // Reverse
            var reversedIntegers = numbers_list_1.Reverse<int>().ToList();
            Console.Write("numbers_list_1.Reverse() -> ");
            printList(reversedIntegers);

            // OrderBy
            var products_listOrderedByName = products_list.OrderBy(x => x.Name).ToList();
            Console.Write("products_list.OrderBy(x => x.Name) -> ");
            printList(products_listOrderedByName);

            // OrderByDescenting
            var products_listOrderedByNameDescending = products_list.OrderByDescending(x => x.Name).ToList();
            Console.Write("products_list.OrderByDescending(x => x.Name) -> ");
            printList(products_listOrderedByNameDescending);

            // OrderBy - ThenBy
            var products_listOrderedByNameThenByPrice = products_list.OrderBy(x => x.Name).ThenBy(x => x.Price).ToList();
            Console.Write("products_list.OrderBy(x => x.Name).ThenBy(x => x.Price) -> ");
            printList(products_listOrderedByNameThenByPrice);


            /*
                Grouping operators
             */
            
            //GroupBy
            var products_listGroupedByPrice = products_list.GroupBy(x => x.Price);
            Console.WriteLine("products_list.GroupBy(x => x.Price) -> ");
            foreach (var x in products_listGroupedByPrice) {
                var key = x.Key;
                var values = x.ToList();
                Console.WriteLine($"Key = {key}");
                Console.Write("Values = ");
                printList(values);
            }

            /*
                Set operators
             */

            // Distinct
            var distinct1 = numbers_list_1.Distinct().ToList();
            Console.Write("numbers_list_1.Distinct() -> ");
            printList(distinct1);

            // Union
            var union = numbers_list_1.Union(numbers_list_2).ToList();
            Console.Write("numbers_list_1.Union(numbers_list_2) -> ");            
            printList(union);

            // Intersect
            var intersect = numbers_list_1.Intersect(numbers_list_2).ToList();
            Console.Write("numbers_list_1.Intersect(numbers_list_2) -> ");                        
            printList(intersect);

            // Except
            var number1ExceptNumber2 = numbers_list_1.Except(numbers_list_2).ToList();
            Console.Write("numbers_list_1.Except(numbers_list_2) -> ");
            printList(number1ExceptNumber2);

            var number2ExceptNumber1 = numbers_list_2.Except(numbers_list_1).ToList();
            Console.Write("numbers_list_2.Except(numbers_list_1) -> ");
            printList(number2ExceptNumber1);

            /* 
                Quantifiers operators 
             */

            // All 
            var allPositive = numbers_list_1.All(x => x > 0);
            Console.Write("numbers_list_1.All(x => x > 0) -> ");
            Console.WriteLine(allPositive);

            // Any
            var anyPositive = numbers_list_1.Any(x => x > 0);
            Console.Write("numbers_list_1.Any(x => x > 0) -> ");
            Console.WriteLine(anyPositive);
            
            /*
                Aggregate operators            
             */

            // Count
            var count = numbers_list_1.Count();
            Console.WriteLine($"numbers_list_1.Count() -> {count}");

            // Sum
            var sum = numbers_list_1.Sum();
            Console.WriteLine($"numbers_list_1.Sum() -> {sum}");

            var sumProductPrices = products_list.Sum(x => x.Price);
            Console.WriteLine($"products_list.Sum(x => x.Price) -> {sumProductPrices}");

            // Max
            var maxProductPrices = products_list.Max(x => x.Price);
            Console.WriteLine($"products_list.Max(x => x.Price) -> {maxProductPrices}");

            // Min
            var minProductPrices = products_list.Min(x => x.Price);
            Console.WriteLine($"products_list.Min(x => x.Price) -> {minProductPrices}");

            // Average
            var averageProductPrices = products_list.Average(x => x.Price);
            Console.WriteLine($"products_list.Average(x => x.Price) -> {averageProductPrices}");
        }

        static void printList(List<int> list) {
            foreach (var x in list) {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        static void printList(List<string> list) {
            foreach (var x in list) {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        static void printList(List<Product> list) {
            foreach (var x in list) {
                Console.Write($"({x.Name},{x.Price}) ");
            }
            Console.WriteLine();
        }
    }
}

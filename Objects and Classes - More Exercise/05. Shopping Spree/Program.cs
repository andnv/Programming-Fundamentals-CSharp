namespace _05._Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] inputPerson = Console.ReadLine().Split(";");

            for (int i = 0; i < inputPerson.Length; i++)
            {
                string[] personInfo = inputPerson[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);
                people.Add(person);
            }

            string[] inputProduct = Console.ReadLine().Split(";");

            for (int i = 0; i < inputProduct.Length; i++)
            {
                string[] bagInfo = inputProduct[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = bagInfo[0];
                decimal cost = decimal.Parse(bagInfo[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] productsInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = productsInfo[0];
                string product = productsInfo[1];

                foreach (Person currPerson in people
                    .Where(p => p.Name == personName))
                {
                    foreach (Product currProduct in products
                        .Where(pr => pr.Name == product))
                    {
                        if (currPerson.Money >= currProduct.Cost)
                        {
                            Console.WriteLine($"{currPerson.Name} bought {currProduct.Name}");
                            currPerson.Money -= currProduct.Cost;
                            currPerson.BagOfProducts.Add(currProduct.Name);
                        }
                        else if (currProduct.Cost > currPerson.Money)
                        {
                            Console.WriteLine($"{currPerson.Name} can't afford {currProduct.Name}");
                        }
                        break;
                    }
                    break;
                }
            }

            foreach (Person person in people.Where(p => p.BagOfProducts.Count > 0))
            {
                Console.Write($"{person.Name} - ");
                Console.WriteLine(string.Join(", ", person.BagOfProducts));
            }
            foreach (Person person in people.Where(p => p.BagOfProducts.Count <= 0))
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }
    }

    public class Person
    {
        private readonly List<string> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;

            bagOfProducts = new List<string>();
        }

        public string Name { get; set; }    

        public decimal Money { get; set; }

        public List<string> BagOfProducts
            => this.bagOfProducts;
    }

    public class Product 
    {
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public decimal Cost { get; set; }
    }
}

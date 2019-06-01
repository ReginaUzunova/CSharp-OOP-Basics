using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] peopleInfo = Console.ReadLine()
                .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            string[] productsInfo = Console.ReadLine()
                .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            string[] command = Console.ReadLine().Split();

            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                for (int i = 0; i < peopleInfo.Length; i+=2)
                {
                    string personName = peopleInfo[i];
                    decimal personMoney = decimal.Parse(peopleInfo[i + 1]);

                    Person person = new Person(personName, personMoney);
                    persons.Add(person);
                }

                for (int i = 0; i < productsInfo.Length; i+=2)
                {
                    string productName = productsInfo[i];
                    decimal productCost = decimal.Parse(productsInfo[i + 1]);

                    Product product = new Product(productName, productCost);
                    products.Add(product);
                }
                while (command[0] != "END")
                {
                    string shoppingPerson = command[0];
                    string shoppingProduct = command[1];

                    Person person = persons.FirstOrDefault(x => x.Name == shoppingPerson);
                    Product product = products.FirstOrDefault(x => x.Name == shoppingProduct);

                    person.AddProduct(product);

                    command = Console.ReadLine().Split();
                }

                foreach (var person in persons)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

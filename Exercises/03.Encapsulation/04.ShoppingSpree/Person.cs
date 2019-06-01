using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }
       
        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public void AddProduct(Product product)
        {
            decimal cost = product.Cost;
            string productName = product.Name;

            if (cost <= this.money)
            {
                this.Money -= cost;
                this.Products.Add(product);
                Console.WriteLine($"{this.Name} bought {productName}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {productName}");
            }
        }

        public override string ToString()
        {
            if (products.Count > 0)
            {
                return $"{this.Name} - {string.Join(", ", products.Select(p => p.ToString()))}";
            }
            else
            {
                return $"{this.Name} - Nothing bought";
            }
        }
    }
}

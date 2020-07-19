using System;
using System.Collections.Generic;

namespace CollectionExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create List
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer
            {
                ID = "1",
                Name = "C1",
                Salary = 5000,
            });

            customers.Add(new Customer
            {
                ID = "2",
                Name = "C2",
                Salary = 15000,
            });

            customers.Add(new Customer
            {
                ID = "3",
                Name = "C3",
                Salary = 2000,
            });

            // Iterate List
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.Format());
            }

            // Iterate List
            customers.ForEach(c => {
                Console.WriteLine(c.Format());
            });

            // Create Dictionary
            Dictionary<string, Customer> customerIndex = new Dictionary<string, Customer>();
            foreach (Customer c in customers)
            {
                customerIndex.Add(c.ID, c);
            }

            Console.WriteLine(customerIndex["1"].Salary);

            // Key Value pair
            foreach(KeyValuePair<string, Customer> ckv in customerIndex)
            {
                Console.WriteLine(string.Format("Key: {0}, Value.Salary: {1}", ckv.Key, ckv.Value.Salary));
            }
        }
    }

    class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Format()
        {
            return string.Format("ID: {0} Name: {1} Salary {2}", this.ID, this.Name, this.Salary);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UsingArray();
            UsingList();
        }

        static void UsingArray()
        {
            Person[] persons = new Person[2];

            // Add Person 1
            persons[0] = new Person
            {
                ID = 1,
                Name = "Person 1",
                Salary = 2000,
            };

            // Add Person 2
            persons[1] = new Person
            {
                ID = 2,
                Name = "Person 2",
                Salary = 5000,
            };

            // Query
            var p_gte_2500 = from p in persons where p.Salary > 2500 select p;

            foreach (var p in p_gte_2500)
            {
                Console.WriteLine(p.Format());
            }

        }

        static void UsingList()
        {
            List<Person> persons = new List<Person>();

            // Add Person 1
            persons.Add(new Person
            {
                ID = 1,
                Name = "Person 1",
                Salary = 2000,
            });

            // Add Person 2
            persons.Add(new Person
            {
                ID = 2,
                Name = "Person 2",
                Salary = 5000,
            });

            // Query
            var p_lte_2500 = from p in persons where p.Salary < 2500 select p;

            foreach (var p in p_lte_2500)
            {
                Console.WriteLine(p.Format());
            }
        }
    }

    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Format()
        {
            return string.Format("ID: {0} Name: {1} Salary {2}", this.ID, this.Name, this.Salary);
        }
    }
}
